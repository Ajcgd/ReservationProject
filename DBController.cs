using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervace
{
    public class DBController
    {

        private readonly NpgsqlConnection conn = new("Host=localhost;Username=postgres;Password=123;Database=Rezervace");
        public DBController()
        {
            conn.Open();
            conn.TypeMapper.MapEnum<Sex>("sex");
            conn.TypeMapper.MapEnum<FuelType>("fuel_type");
            conn.TypeMapper.MapEnum<VehicleClass>("vehicle_class");
        }

        public object? ExecuteQuery(NpgsqlCommand cmd)
        {
            cmd.Connection = conn;
            return cmd.ExecuteScalar();
        }

        public async Task<bool> CheckUserExist(string username)
        {
            await using var cmd = new NpgsqlCommand(String.Format(@"SELECT COUNT (*) FROM user_data WHERE username='{0}' LIMIT 1", username), conn);
            try
            {
                object? res = cmd.ExecuteScalar();
                if (res == null)
                {
                    MessageBox.Show("DB error");
                    return true;
                }
                return Convert.ToInt64(res) == 1;
            } catch (Exception)
            {
                MessageBox.Show("DB error");
                return true;
            }
        }

        public async Task<UserDataDto?> GetUserData(string Username)
        {
            UserDataDto res;
            NpgsqlDataReader? reader = null;

            try
            {
                res = new UserDataDto();

                await using var cmd = new NpgsqlCommand(@"SELECT * FROM user_data WHERE username=($1) LIMIT 1", conn)
                {
                    Parameters =
                    {
                        new() { Value = Username },
                    }
                };

                object[] values = new object[6];

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValues(values);
                }

                if (DBNull.Value.Equals(values[0]))
                {
                    return null;
                }

                res.name = DBNull.Value.Equals(values[1]) ? "" : (string)values[1]!;
                res.surname = DBNull.Value.Equals(values[2]) ? "" : (string)values[2]!;
                res.licence = DBNull.Value.Equals(values[3]) ? null : Decimal.ToInt32((decimal)values[3]!);
                res.dob = DBNull.Value.Equals(values[4]) ? null : (DateTime)values[4]!;
                res.sex = DBNull.Value.Equals(values[5]) ? Sex.Undefined : (Sex)values[5]!;
            }
            finally
            {
                reader!.Close();
                reader.Dispose();
            }

            return res;
        }

        public async Task<bool> IsAdmin(string Username)
        {
            string command = String.Format(@"SELECT is_admin FROM user_data WHERE username='{0}' LIMIT 1", Username);
            await using var cmd = new NpgsqlCommand(command, conn);
            object? res = cmd.ExecuteScalar();
            if (res == null)
            {
                MessageBox.Show("DB error");
                return false;
            }
            else
            {
                return (bool)res;
            }


        }

        public async void SetUserData(UserDataDto data)
        {
            string command = @"UPDATE user_data SET";
            if (data.name != null)
            {
                command += String.Format(" real_name='{0}',", data.name);
            }
            if (data.surname != null)
            {
                command += String.Format(" surname='{0}',", data.surname);
            }
            if (data.licence != null)
            {
                command += String.Format(" license='{0}',", data.licence.ToString());
            }if (data.dob != null)
            {
                command += String.Format(" dob='{0}',", data.dob.ToString());
            }
            if (data.sex != null)
            {
                command += String.Format(" sex='{0}',", data.sex.ToString());
            }
            command = command.Remove(command.Length - 1);
            command += String.Format(" WHERE username='{0}'", MainForm.Username); 
            try
            {
                await using var cmd = new NpgsqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("DB error");
            }

        }

        public async Task<bool> RegisterUser(string Username, string passwordHash)
        {
            try
            {
                await using var cmd = new NpgsqlCommand(@"INSERT INTO user_credentials (username, password_hash) VALUES (($1), ($2))", conn)
                {
                    Parameters =
                    {
                        new() { Value = Username },
                        new() { Value = passwordHash },
                    }
                };
                if (cmd.ExecuteNonQuery() == -1)
                {
                    return false;
                }
                await using var cmd1 = new NpgsqlCommand(@"INSERT INTO user_data (Username, is_admin) VALUES(($1), ($2))", conn)
                {
                    Parameters =
                    {
                        new() { Value = Username },
                        new() { Value = false },
                    }
                };
                return cmd1.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Database error");
                return false;
            }
        }

        public async Task<List<VehicleDTO>> GetVehicles(FilterDTO? filter)
        {
            string command = @"SELECT * FROM vehicles ";
            if (filter != null)
            {
                command += "WHERE";
                if (filter.Value.Brand != null)
                {
                    command += String.Format(" brand='{0}' AND", filter.Value.Brand);
                }
                if (filter.Value.Model != null)
                {
                    command += String.Format(" model='{0}' AND", filter.Value.Model);
                }
                if (filter.Value.Type != null)
                {
                    command += String.Format(" fuel_type='{0}' AND", filter.Value.Type.ToString()!.ToLower());
                }
                if (filter.Value.MinSeats != null)
                {
                    command += String.Format(" seats>='{0}' AND", filter.Value.MinSeats.ToString());
                }
                if (filter.Value.MaxSeats != null)
                {
                    command += String.Format(" seats<='{0}' AND", filter.Value.MaxSeats.ToString());
                }
                if (filter.Value.MinPricePerDay != null)
                {
                    command += String.Format(" price_per_day>='{0}' AND", filter.Value.MinPricePerDay.ToString());
                }
                if (filter.Value.MaxPricePerDay != null)
                {
                    command += String.Format(" price_per_day<='{0}' AND", filter.Value.MaxPricePerDay.ToString());
                }
                if (filter.Value.VClass != null)
                {
                    command += String.Format(" vclass='{0}' AND", filter.Value.VClass.ToString());
                }
                command += String.Format(" id NOT IN (SELECT l.id FROM vehicles l LEFT JOIN reservations r ON (l.id = r.vehicle_id) WHERE (('{0}' <= r.date_to) and ('{1}' >= r.date_from)))", filter.Value.From.ToString(), filter.Value.To.ToString());
            }
            await using var cmd = new NpgsqlCommand(command, conn);
            NpgsqlDataReader? reader = null;
            List<VehicleDTO> data = new();
            try
            {
                object[] values = new object[7];
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValues(values);
                    data.Add(ObjToVehicleDto(values));
                }
                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("DB error");
                return new List<VehicleDTO>();
            }
            finally
            {
                if (reader != null)
                {
                    reader!.Close();
                    reader.Dispose();
                }

            }
        }

        private static VehicleDTO ObjToVehicleDto(object[] obj)
        {
            VehicleDTO dto = new();
            dto.Id = (int)obj[0];
            dto.Brand = (string)obj[1];
            dto.Model = (string)obj[2];
            dto.Type = (FuelType)obj[3];
            dto.Seats = Decimal.ToInt32((decimal)obj[4]);
            dto.PricePerDay = Decimal.ToInt32((decimal)obj[5]);
            dto.VClass = (VehicleClass)obj[6];

            return dto;
        }

        public async Task<bool> CreateReservation(ReservationDTO reservationData)
        {

            string command = String.Format(@"INSERT INTO reservations (vehicle_id, username, date_from, date_to) VALUES ({0}, '{1}', '{2}', '{3}')",
                reservationData.VehicleId, MainForm.Username, reservationData.FromDate, reservationData.ToDate);
            try
            {
                await using var cmd = new NpgsqlCommand(command, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Database error");
                return false;
            }
        }

        public async Task<List<ReservationDetailsDTO>?> ListReservations(string Username, bool displayAll)
        {
            string command = String.Format(@"SELECT reservation_id, brand, model, fuel_type, date_from, date_to, price_per_day FROM reservations l LEFT JOIN vehicles r ON (l.vehicle_id = r.id)");
            if (!displayAll)
            {
                command += String.Format("WHERE Username = '{0}'", Username);
            }

            List<ReservationDetailsDTO> list = new();
            await using var cmd = new NpgsqlCommand(command, conn);
            NpgsqlDataReader? reader = null;
            try
            {
                object[] values = new object[7];
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetValues(values);
                    list.Add(ObjToReservationDetailsDTO(values));
                }
                return list;
            }
            catch (Exception)
            {
                MessageBox.Show("Database error");
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader!.Close();
                    reader.Dispose();
                }
            }
        }

        private static ReservationDetailsDTO ObjToReservationDetailsDTO(object[] obj)
        {
            ReservationDetailsDTO dto = new();
            dto.Id = (int)obj[0];
            dto.Brand = (string)obj[1];
            dto.Model = (string)obj[2];
            dto.Type = (FuelType)obj[3];
            dto.FromDate = (DateTime)obj[4];
            dto.ToDate = (DateTime)obj[5];
            dto.PricePerDay = Decimal.ToInt32((decimal)obj[6]);

            return dto;
        }

        public async Task<bool> DeleteReservation(int reservationId)
        {
            string command = String.Format(@"DELETE FROM reservations WHERE reservation_id = '{0}'", reservationId.ToString());
            await using var cmd = new NpgsqlCommand(command, conn);
            return cmd.ExecuteNonQuery() == 1;
        }

        public async Task<bool> AddVehicle(VehicleDTO vehicle)
        {
            string command = String.Format(@"INSERT INTO vehicles (brand, model, fuel_type, seats, price_per_day, vclass) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                vehicle.Brand, vehicle.Model, vehicle.Type.ToString().ToLower(), vehicle.Seats.ToString(), vehicle.PricePerDay.ToString(), vehicle.VClass.ToString());
            await using var cmd = new NpgsqlCommand(command, conn);
            return cmd.ExecuteNonQuery() == 1;
        }

        public async Task<bool> UpdateVehicle(VehicleDTO vehicle)
        {
            string command = String.Format(@"UPDATE vehicles SET brand='{0}', model='{1}', fuel_type='{2}', seats='{3}', price_per_day='{4}', vclass='{5}' WHERE id={6}",
                vehicle.Brand, vehicle.Model, vehicle.Type.ToString().ToLower(), vehicle.Seats.ToString(), vehicle.PricePerDay.ToString(), vehicle.VClass.ToString(), vehicle.Id.ToString());
            await using var cmd = new NpgsqlCommand(command, conn);
            return cmd.ExecuteNonQuery() == 1;
        }

        public async Task<bool> DeleteVehicle(int id)
        {
            string commandCheck = String.Format(@"SELECT COUNT (*) FROM reservations WHERE vehicle_id='{0}' AND date_to>='{1}'", id.ToString(), DateTime.Now.ToString());
            await using var cmd = new NpgsqlCommand(commandCheck, conn);
            object? count = cmd.ExecuteScalar();
            if (count == null)
            {
                MessageBox.Show("DB error");
                return false;
            }
            if (Convert.ToInt64(count) != 0)
            {
                MessageBox.Show("Can't delete car with pending reservations");
                return false;
            }
            else
            {
                string command = String.Format(@"DELETE FROM vehicles WHERE id='{0}'", id.ToString());
                await using var cmd1 = new NpgsqlCommand(command, conn);
                return cmd1.ExecuteNonQuery() == 1;

            }
        }
    }
}
