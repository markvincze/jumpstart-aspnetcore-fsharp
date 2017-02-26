namespace JumpstartAspnetCoreFsharp

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open System
open System.IO

type Startup() =
    member __.ConfigureServices(services: IServiceCollection) =
        services.AddMvc() |> ignore
    member __.Configure (app : IApplicationBuilder)
                        (env : IHostingEnvironment)
                        (loggerFactory : ILoggerFactory) =
        loggerFactory.AddConsole() |> ignore
        app.UseMvc() |> ignore