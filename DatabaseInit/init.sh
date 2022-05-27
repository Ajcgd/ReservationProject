if test $# -ne 2 
    then
        echo "Requited two parameters: username and password"
else 
    $PGPASSWORD=$2;
    psql -U $1 -c "DROP DATABASE pokus"
    psql -U $1 -f ./createDB.sql
    psql -U $1 -d pokus -f ./createTypes.sql
    psql -U $1 -d pokus -f ./createTables.sql
    psql -U $1 -d pokus -f ./createAdmin.sql
fi

