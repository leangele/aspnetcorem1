# aspnetcorem1

https://www.microsoft.com/net/core#windowsvs2017 (sdk core)

angular v4 typescript snipper author johnpapa
ASP.NET helper
Auto Import
Beautify
C#
C# extension
Docker
HTML SCSS Support
mssql
REST Client

`npm install -g yo generator-aspnetcore-spa` (installation yeoman for core)

`yo aspnetcore-spa` creation solution .net with core and angular

`git clone <url>` (inside this folder must be saved the project or run the execution of yeoman)

`$Env:ASPNETCORE_ENVIRONMENT = "Development"`D 
`$Env:ASPNETCORE_ENVIRONMENT = "Production"` 

you can add this variable to the system in windows 
in
control panel /system /advace system/enviroment variables and in system variables you will add 
`variable name: ASPNETCORE_ENVIRONMENT`
`variable value:Production`
`variable value:Development`


https://github.com/aspnet/DotNetTools/tree/dev/src/Microsoft.DotNet.Watcher.Tools
add watcher to execute automaticaly wien tu need start a 
`dotnet run`
 `<ItemGroup>`
    `<DotNetCliToolReference` `Include="Microsoft.DotNet.Watcher.Tools" Version="1.0.0" />`
  `</ItemGroup>`

  add this code in csproj
  after added you need run `dotnet restore`
  now you need modify your execution to `dotnet watch run`

1. `git pull origin master` (bring all changes from my repository remote)
2.  `git add .` (allow the creation of new files when exist a previous version)
3.  `git commit -am "mesage"` (create a restore point for the project localy)
4.  `git push origin master` (send information to Repository remote)
