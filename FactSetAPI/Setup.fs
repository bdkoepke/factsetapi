module Setup

open System
open Microsoft.AspNet.OData.Builder
open Microsoft.AspNet.OData.Extensions
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection

open FactSetAPI.Models.Etfdb

let configureApp (app: IApplicationBuilder) =
    app.UseDeveloperExceptionPage().UseMvc(fun rb ->
        let maxTopValue = Nullable(1000)
        let pageSizeValue = Nullable(5)
        let b = new ODataConventionModelBuilder()
        b.EntitySet<Holidays>("Holidays").EntityType.Page(maxTopValue, pageSizeValue) |> ignore
        rb.Count().Expand().Filter().MaxTop(maxTopValue).OrderBy().Select() |> ignore
        rb.MapODataServiceRoute("odata", null, b.GetEdmModel()) |> ignore
        rb.EnableDependencyInjection() |> ignore
    ) |> ignore

let configureServices (services : IServiceCollection) =
    services
        .AddODataQueryFilter()
        .AddOData().Services
        .AddMvcCore()
        |> ignore

let configureAppConfiguration (_:WebHostBuilderContext) (builder : IConfigurationBuilder) =
    builder.AddEnvironmentVariables() |> ignore

[<EntryPoint>]
let main _ =
    WebHostBuilder()
        .UseKestrel()
        .UseIISIntegration()
        .ConfigureAppConfiguration(Action<WebHostBuilderContext, IConfigurationBuilder> configureAppConfiguration)
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .Build()
        .Run()
    0
