if ($args.Count -ne 2) {
    Write-Output "Requited two parameters: username and password"
} else {
    $env:PGPASSWORD=$args[1];
    psql -U $args[0] -c "DROP DATABASE pokus"
    psql -U $args[0] -f ./createDB.sql
    psql -U $args[0] -d pokus -f ./createTypes.sql
    psql -U $args[0] -d pokus -f ./createTables.sql
    psql -U $args[0] -d pokus -f ./createAdmin.sql
}

