# workout-helper-ef

List of commands

for installing nuget via cli

``
 dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.25
 ``

 for adding migration

 ``

 dotnet tool install -g dotnet-ef --version 6.0.0

 dotnet ef migrations add InitialCreate

 ``

 for running migration

 ``

 dotnet ef database update

 ``