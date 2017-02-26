namespace JumpstartAspnetCoreFsharp.Controllers

open System
open Microsoft.AspNetCore.Mvc

[<Route("[controller]")>]
type HelloController() =
    inherit Controller()
    member this.Get() =
        this.Ok "Hello from F# + ASP.NET Core!"