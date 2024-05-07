# C# Tutorial Learnning
## Initialization

[reference link](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)
```bash
// Create a blank solution
dotnet new sln 
// or
dotnet new solution

// add an .gitignore file
dotnet new gitignore

// create an console project and add to solution
dotnet new console --output ./Basic
dotnet sln add .\Basic\

// list all projects in solution file
dotnet sln list
```
