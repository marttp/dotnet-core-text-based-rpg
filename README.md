# Create project
dotnet new webapi -n TextBasedRPG

# Run server
dotnet run

# Install DotNet DependencyInjection
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

# Knowledge
- Use generic wrapper class for more ux response
- Use DTO for mapping response field
- Use AutoMapper for making Model class mapping to DTO