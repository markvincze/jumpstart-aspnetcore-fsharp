open JumpstartAspnetCoreFsharp
open System
open System.IO
open Microsoft.AspNetCore.Hosting

[<EntryPoint>]
let main argv = 
  let host =
    WebHostBuilder()
      .UseKestrel()
      .UseUrls("http://*:5000/")
      .UseContentRoot(Directory.GetCurrentDirectory())
      .UseStartup<Startup>()
      .Build()

  host.Run()
  0 // return an integer exit code
