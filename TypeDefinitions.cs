using NpgsqlTypes;
using System.ComponentModel;


namespace Rezervace
{
    public enum Sex
    {
        [PgName("Male")]
        Male,
        [PgName("Female")]
        Female,
        [PgName("Other")]
        Other,
        [PgName("Undefined")]
        Undefined
    }
    public enum FuelType
    {
        [PgName("diesel")]
        Diesel,
        [PgName("benzin")]
        Benzin,
        [PgName("gas")]
        Gas,
        [PgName("electric")]
        Electric
    }
    public enum VehicleClass
    {
        [PgName("Premium")]
        Premium,
        [PgName("Business")]
        Business,
        [PgName("Economy")]
        Economy
    }
    public struct UserDataDto
    {
        public string? name;
        public string? surname;
        public int? licence;
        public DateTime? dob;
        public Sex? sex;
    }

    public struct VehicleDTO
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public FuelType Type { get; set; }
        public int Seats { get; set; }
        public int PricePerDay { get; set; }
        public VehicleClass VClass { get; set; }
    }
    public struct FilterDTO
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public FuelType? Type { get; set; }
        public int? MinSeats { get; set; }
        public int? MaxSeats { get; set; }
        public int? MinPricePerDay { get; set; }
        public int? MaxPricePerDay { get; set; }
        public VehicleClass? VClass { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }

    public struct ReservationDTO
    {
        public int VehicleId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public struct ReservationDetailsDTO
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public FuelType Type { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int PricePerDay { get; set; }
    }
}
