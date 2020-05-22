# Create project
dotnet new webapi -n TextBasedRPG

# Run server
dotnet run

# Install DotNet DependencyInjection
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

# Install Token package
dotnet add package Microsoft.IdentityModel.Tokens
dotnet add package System.IdentityModel.Tokens.Jwt
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

# Install Entity Framework Core for SQL server
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
# Entity Framework migrations
dotnet tool install --global dotnet-ef
# Entity Framework
dotnet add package Microsoft.EntityFrameworkCore.Design
# Migration
- dotnet ef -h
- 1. dotnet ef migrations add InitialCreate
- You got a file of migration => These files are used by Entity Framework so that it knows what it should do with this migration. They provide information about your tables and fields that Entity Framework uses to build your database
- 2. dotnet ef database update
- dotnet ef migrations remove

dotnet ef migrations add User
dotnet ef migrations add Character
dotnet ef migrations add Weapon
dotnet ef migrations add Skill

# Add migration
dotnet ef migrations add [Class]
# Add relations
dotnet ef migrations add [class1+class2+Relation]

dotnet ef migrations add UserCharacterRelation
dotnet ef migrations add FightProperties

# Knowledge
- Use generic wrapper class for more ux response
- Use DTO for mapping response field
- Use AutoMapper for making Model class mapping to DTO