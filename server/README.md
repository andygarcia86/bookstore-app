# Bookstore Application - Server

The server side is built in using .Net Core 3.1 version

## Tools & Requirements

 - Visual Studio 2019
 - .Net Core 3.1

## TDD


## Database

For adding new migrations:

`Add-Migration MigrationName -Verbose -Context BookStoreDbContext`

For apply and update the migrations to the Database:

`Update-Database -Verbose -Context BookStoreDbContext`
