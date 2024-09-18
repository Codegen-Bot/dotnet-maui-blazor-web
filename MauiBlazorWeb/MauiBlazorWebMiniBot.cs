using CodegenBot;
using Humanizer;

namespace MauiBlazorWeb;

public class MauiBlazorWebMiniBot : IMiniBot
{
    public void Execute()
    {
        var configuration = GraphQLOperations.GetConfiguration().Configuration;

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Layout/MainLayout.razor",
            $$""""
            @inherits LayoutComponentBase
              
              <div class="page">
                  <div class="sidebar">
                      <NavMenu />
                  </div>
              
                  <main>
                      <div class="top-row px-4">
                          <a href="https://learn.microsoft.com/aspnet/core/" target="_blank">About</a>
                      </div>
              
                      <article class="content px-4">
                          @Body
                      </article>
                  </main>
              </div>
              
              <div id="blazor-error-ui" data-nosnippet>
                  An unhandled error has occurred.
                  <a href="." class="reload">Reload</a>
                  <span class="dismiss">X</span>
              </div>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Layout/MainLayout.razor.css",
            $$""""
            .page {
                  position: relative;
                  display: flex;
                  flex-direction: column;
              }
              
              main {
                  flex: 1;
              }
              
              .sidebar {
                  background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);
              }
              
              .top-row {
                  background-color: #f7f7f7;
                  border-bottom: 1px solid #d6d5d5;
                  justify-content: flex-end;
                  height: 3.5rem;
                  display: flex;
                  align-items: center;
              }
              
                  .top-row ::deep a, .top-row ::deep .btn-link {
                      white-space: nowrap;
                      margin-left: 1.5rem;
                      text-decoration: none;
                  }
              
                  .top-row ::deep a:hover, .top-row ::deep .btn-link:hover {
                      text-decoration: underline;
                  }
              
                  .top-row ::deep a:first-child {
                      overflow: hidden;
                      text-overflow: ellipsis;
                  }
              
              @media (max-width: 640.98px) {
                  .top-row {
                      justify-content: space-between;
                  }
              
                  .top-row ::deep a, .top-row ::deep .btn-link {
                      margin-left: 0;
                  }
              }
              
              @media (min-width: 641px) {
                  .page {
                      flex-direction: row;
                  }
              
                  .sidebar {
                      width: 250px;
                      height: 100vh;
                      position: sticky;
                      top: 0;
                  }
              
                  .top-row {
                      position: sticky;
                      top: 0;
                      z-index: 1;
                  }
              
                  .top-row.auth ::deep a:first-child {
                      flex: 1;
                      text-align: right;
                      width: 0;
                  }
              
                  .top-row, article {
                      padding-left: 2rem !important;
                      padding-right: 1.5rem !important;
                  }
              }
              
              #blazor-error-ui {
                  background: lightyellow;
                  bottom: 0;
                  box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);
                  box-sizing: border-box;
                  display: none;
                  left: 0;
                  padding: 0.6rem 1.25rem 0.7rem 1.25rem;
                  position: fixed;
                  width: 100%;
                  z-index: 1000;
              }
              
                  #blazor-error-ui .dismiss {
                      cursor: pointer;
                      position: absolute;
                      right: 0.75rem;
                      top: 0.5rem;
                  }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Layout/NavMenu.razor",
            $$""""
            <div class="top-row ps-3 navbar navbar-dark">
                  <div class="container-fluid">
                      <a class="navbar-brand" href="">{{configuration.AppName}}</a>
                  </div>
              </div>
              
              <input type="checkbox" title="Navigation menu" class="navbar-toggler" />
              
              <div class="nav-scrollable" onclick="document.querySelector('.navbar-toggler').click()">
                  <nav class="flex-column">
                      <div class="nav-item px-3">
                          <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
                              <span class="bi bi-house-door-fill-nav-menu" aria-hidden="true"></span> Home
                          </NavLink>
                      </div>
              
                      <div class="nav-item px-3">
                          <NavLink class="nav-link" href="counter">
                              <span class="bi bi-plus-square-fill-nav-menu" aria-hidden="true"></span> Counter
                          </NavLink>
                      </div>
              
                      <div class="nav-item px-3">
                          <NavLink class="nav-link" href="weather">
                              <span class="bi bi-list-nested-nav-menu" aria-hidden="true"></span> Weather
                          </NavLink>
                      </div>
                  </nav>
              </div>
              
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Layout/NavMenu.razor.css",
            $$""""
            .navbar-toggler {
                  appearance: none;
                  cursor: pointer;
                  width: 3.5rem;
                  height: 2.5rem;
                  color: white;
                  position: absolute;
                  top: 0.5rem;
                  right: 1rem;
                  border: 1px solid rgba(255, 255, 255, 0.1);
                  background: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%28255, 255, 255, 0.55%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e") no-repeat center/1.75rem rgba(255, 255, 255, 0.1);
              }
              
              .navbar-toggler:checked {
                  background-color: rgba(255, 255, 255, 0.5);
              }
              
              .top-row {
                  height: 3.5rem;
                  background-color: rgba(0,0,0,0.4);
              }
              
              .navbar-brand {
                  font-size: 1.1rem;
              }
              
              .bi {
                  display: inline-block;
                  position: relative;
                  width: 1.25rem;
                  height: 1.25rem;
                  margin-right: 0.75rem;
                  top: -1px;
                  background-size: cover;
              }
              
              .bi-house-door-fill-nav-menu {
                  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-house-door-fill' viewBox='0 0 16 16'%3E%3Cpath d='M6.5 14.5v-3.505c0-.245.25-.495.5-.495h2c.25 0 .5.25.5.5v3.5a.5.5 0 0 0 .5.5h4a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4a.5.5 0 0 0 .5-.5Z'/%3E%3C/svg%3E");
              }
              
              .bi-plus-square-fill-nav-menu {
                  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-plus-square-fill' viewBox='0 0 16 16'%3E%3Cpath d='M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0z'/%3E%3C/svg%3E");
              }
              
              .bi-list-nested-nav-menu {
                  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-list-nested' viewBox='0 0 16 16'%3E%3Cpath fill-rule='evenodd' d='M4.5 11.5A.5.5 0 0 1 5 11h10a.5.5 0 0 1 0 1H5a.5.5 0 0 1-.5-.5zm-2-4A.5.5 0 0 1 3 7h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5zm-2-4A.5.5 0 0 1 1 3h10a.5.5 0 0 1 0 1H1a.5.5 0 0 1-.5-.5z'/%3E%3C/svg%3E");
              }
              
              .nav-item {
                  font-size: 0.9rem;
                  padding-bottom: 0.5rem;
              }
              
                  .nav-item:first-of-type {
                      padding-top: 1rem;
                  }
              
                  .nav-item:last-of-type {
                      padding-bottom: 1rem;
                  }
              
                  .nav-item ::deep .nav-link {
                      color: #d7d7d7;
                      background: none;
                      border: none;
                      border-radius: 4px;
                      height: 3rem;
                      display: flex;
                      align-items: center;
                      line-height: 3rem;
                      width: 100%;
                  }
              
              .nav-item ::deep a.active {
                  background-color: rgba(255,255,255,0.37);
                  color: white;
              }
              
              .nav-item ::deep .nav-link:hover {
                  background-color: rgba(255,255,255,0.1);
                  color: white;
              }
              
              .nav-scrollable {
                  display: none;
              }
              
              .navbar-toggler:checked ~ .nav-scrollable {
                  display: block;
              }
              
              @media (min-width: 641px) {
                  .navbar-toggler {
                      display: none;
                  }
              
                  .nav-scrollable {
                      /* Never collapse the sidebar for wide screens */
                      display: block;
              
                      /* Allow sidebar to scroll for tall menus */
                      height: calc(100vh - 3.5rem);
                      overflow-y: auto;
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/{configuration.AppName}.Shared.csproj",
            $$""""
            <Project Sdk="Microsoft.NET.Sdk.Razor">
              
                <PropertyGroup>
                  <TargetFramework>net9.0</TargetFramework>
                  <Nullable>enable</Nullable>
                  <ImplicitUsings>enable</ImplicitUsings>
                </PropertyGroup>
              
                <ItemGroup>
                  <SupportedPlatform Include="browser" />
                </ItemGroup>
              
                <ItemGroup>
                  <PackageReference Include="Microsoft.AspNetCore.Components.Web" Version="9.0.0-rc.1.24452.1" />
                </ItemGroup>
              
              </Project>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Pages/Counter.razor",
            $$""""
            @page "/counter"
              
              <PageTitle>Counter</PageTitle>
              
              <h1>Counter</h1>
              
              <p role="status">Current count: @currentCount</p>
              
              <button class="btn btn-primary" @onclick="IncrementCount">Click me</button>
              
              @code {
                  private int currentCount = 0;
              
                  private void IncrementCount()
                  {
                      currentCount++;
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Pages/Home.razor",
            $$""""
            @page "/"
              @using {{configuration.AppName}}.Shared.Services
              @inject IFormFactor FormFactor
              
              <PageTitle>Home</PageTitle>
              
              <h1>Hello, world!</h1>
              
              Welcome to your new app running on <em>@factor</em> using <em>@platform</em>.
              
              @code {
                  private string factor => FormFactor.GetFormFactor();
                  private string platform => FormFactor.GetPlatform();
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Pages/Weather.razor",
            $$""""
            @page "/weather"
              
              <PageTitle>Weather</PageTitle>
              
              <h1>Weather</h1>
              
              <p>This component demonstrates showing data.</p>
              
              @if (forecasts == null)
              {
                  <p><em>Loading...</em></p>
              }
              else
              {
                  <table class="table">
                      <thead>
                          <tr>
                              <th>Date</th>
                              <th>Temp. (C)</th>
                              <th>Temp. (F)</th>
                              <th>Summary</th>
                          </tr>
                      </thead>
                      <tbody>
                          @foreach (var forecast in forecasts)
                          {
                              <tr>
                                  <td>@forecast.Date.ToShortDateString()</td>
                                  <td>@forecast.TemperatureC</td>
                                  <td>@forecast.TemperatureF</td>
                                  <td>@forecast.Summary</td>
                              </tr>
                          }
                      </tbody>
                  </table>
              }
              
              @code {
                  private WeatherForecast[]? forecasts;
              
                  protected override async Task OnInitializedAsync()
                  {
                      // Simulate asynchronous loading to demonstrate a loading indicator
                      await Task.Delay(500);
              
                      var startDate = DateOnly.FromDateTime(DateTime.Now);
                      var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
                      forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                      {
                          Date = startDate.AddDays(index),
                          TemperatureC = Random.Shared.Next(-20, 55),
                          Summary = summaries[Random.Shared.Next(summaries.Length)]
                      }).ToArray();
                  }
              
                  private class WeatherForecast
                  {
                      public DateOnly Date { get; set; }
                      public int TemperatureC { get; set; }
                      public string? Summary { get; set; }
                      public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Routes.razor",
            $$""""
            <Router AppAssembly="typeof(Layout.MainLayout).Assembly">
                  <Found Context="routeData">
                      <RouteView RouteData="routeData" DefaultLayout="typeof(Layout.MainLayout)" />
                      <FocusOnNavigate RouteData="routeData" Selector="h1" />
                  </Found>
              </Router>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/Services/IFormFactor.cs",
            $$""""
            namespace {{configuration.AppName}}.Shared.Services;
              
              public interface IFormFactor
              {
                  public string GetFormFactor();
                  public string GetPlatform();
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/wwwroot/app.css",
            $$""""
            html, body {
                  font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;
              }
              
              a, .btn-link {
                  color: #006bb7;
              }
              
              .btn-primary {
                  color: #fff;
                  background-color: #1b6ec2;
                  border-color: #1861ac;
              }
              
              .btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
                box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
              }
              
              .content {
                  padding-top: 1.1rem;
              }
              
              h1:focus {
                  outline: none;
              }
              
              .valid.modified:not([type=checkbox]) {
                  outline: 1px solid #26b050;
              }
              
              .invalid {
                  outline: 1px solid #e50000;
              }
              
              .validation-message {
                  color: #e50000;
              }
              
              .blazor-error-boundary {
                  background: url(data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNTYiIGhlaWdodD0iNDkiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIG92ZXJmbG93PSJoaWRkZW4iPjxkZWZzPjxjbGlwUGF0aCBpZD0iY2xpcDAiPjxyZWN0IHg9IjIzNSIgeT0iNTEiIHdpZHRoPSI1NiIgaGVpZ2h0PSI0OSIvPjwvY2xpcFBhdGg+PC9kZWZzPjxnIGNsaXAtcGF0aD0idXJsKCNjbGlwMCkiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0yMzUgLTUxKSI+PHBhdGggZD0iTTI2My41MDYgNTFDMjY0LjcxNyA1MSAyNjUuODEzIDUxLjQ4MzcgMjY2LjYwNiA1Mi4yNjU4TDI2Ny4wNTIgNTIuNzk4NyAyNjcuNTM5IDUzLjYyODMgMjkwLjE4NSA5Mi4xODMxIDI5MC41NDUgOTIuNzk1IDI5MC42NTYgOTIuOTk2QzI5MC44NzcgOTMuNTEzIDI5MSA5NC4wODE1IDI5MSA5NC42NzgyIDI5MSA5Ny4wNjUxIDI4OS4wMzggOTkgMjg2LjYxNyA5OUwyNDAuMzgzIDk5QzIzNy45NjMgOTkgMjM2IDk3LjA2NTEgMjM2IDk0LjY3ODIgMjM2IDk0LjM3OTkgMjM2LjAzMSA5NC4wODg2IDIzNi4wODkgOTMuODA3MkwyMzYuMzM4IDkzLjAxNjIgMjM2Ljg1OCA5Mi4xMzE0IDI1OS40NzMgNTMuNjI5NCAyNTkuOTYxIDUyLjc5ODUgMjYwLjQwNyA1Mi4yNjU4QzI2MS4yIDUxLjQ4MzcgMjYyLjI5NiA1MSAyNjMuNTA2IDUxWk0yNjMuNTg2IDY2LjAxODNDMjYwLjczNyA2Ni4wMTgzIDI1OS4zMTMgNjcuMTI0NSAyNTkuMzEzIDY5LjMzNyAyNTkuMzEzIDY5LjYxMDIgMjU5LjMzMiA2OS44NjA4IDI1OS4zNzEgNzAuMDg4N0wyNjEuNzk1IDg0LjAxNjEgMjY1LjM4IDg0LjAxNjEgMjY3LjgyMSA2OS43NDc1QzI2Ny44NiA2OS43MzA5IDI2Ny44NzkgNjkuNTg3NyAyNjcuODc5IDY5LjMxNzkgMjY3Ljg3OSA2Ny4xMTgyIDI2Ni40NDggNjYuMDE4MyAyNjMuNTg2IDY2LjAxODNaTTI2My41NzYgODYuMDU0N0MyNjEuMDQ5IDg2LjA1NDcgMjU5Ljc4NiA4Ny4zMDA1IDI1OS43ODYgODkuNzkyMSAyNTkuNzg2IDkyLjI4MzcgMjYxLjA0OSA5My41Mjk1IDI2My41NzYgOTMuNTI5NSAyNjYuMTE2IDkzLjUyOTUgMjY3LjM4NyA5Mi4yODM3IDI2Ny4zODcgODkuNzkyMSAyNjcuMzg3IDg3LjMwMDUgMjY2LjExNiA4Ni4wNTQ3IDI2My41NzYgODYuMDU0N1oiIGZpbGw9IiNGRkU1MDAiIGZpbGwtcnVsZT0iZXZlbm9kZCIvPjwvZz48L3N2Zz4=) no-repeat 1rem/1.8rem, #b32121;
                  padding: 1rem 1rem 1rem 3.7rem;
                  color: white;
              }
              
                  .blazor-error-boundary::after {
                      content: "An error has occurred."
                  }
              
              .darker-border-checkbox.form-check-input {
                  border-color: #929292;
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Shared/_Imports.razor",
            $$""""
            @using System.Net.Http
              @using System.Net.Http.Json
              @using Microsoft.AspNetCore.Components.Forms
              @using Microsoft.AspNetCore.Components.Routing
              @using Microsoft.AspNetCore.Components.Web
              @using static Microsoft.AspNetCore.Components.Web.RenderMode
              @using Microsoft.AspNetCore.Components.Web.Virtualization
              @using Microsoft.JSInterop
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Components/App.razor",
            $$""""
            <!DOCTYPE html>
              <html lang="en">
              
              <head>
                  <meta charset="utf-8" />
                  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
                  <base href="/" />
                  {{CaretRef.New(new CaretTag("location", "Blazor/html/head"))}}
                  <link rel="stylesheet" href="_content/{{configuration.AppName}}.Shared/app.css" />
                  <link rel="stylesheet" href="{{configuration.AppName}}.Web.styles.css" />
                  <link rel="icon" type="image/png" href="_content/{{configuration.AppName}}.Shared/favicon.png" />
                  <HeadOutlet @rendermode="InteractiveServer" />
              </head>
              
              <body>
                  <Routes @rendermode="InteractiveServer" />
                  <script src="_framework/blazor.web.js"></script>
              </body>
              
              </html>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Components/Pages/Error.razor",
            $$""""
            @page "/Error"
              @using System.Diagnostics
              
              <PageTitle>Error</PageTitle>
              
              <h1 class="text-danger">Error.</h1>
              <h2 class="text-danger">An error occurred while processing your request.</h2>
              
              @if (ShowRequestId)
              {
                  <p>
                      <strong>Request ID:</strong> <code>@RequestId</code>
                  </p>
              }
              
              <h3>Development Mode</h3>
              <p>
                  Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
              </p>
              <p>
                  <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
                  It can result in displaying sensitive information from exceptions to end users.
                  For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
                  and restarting the app.
              </p>
              
              @code{
                  [CascadingParameter]
                  private HttpContext? HttpContext { get; set; }
              
                  private string? RequestId { get; set; }
                  private bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
              
                  protected override void OnInitialized() =>
                      RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Components/_Imports.razor",
            $$""""
            @using System.Net.Http
              @using System.Net.Http.Json
              @using Microsoft.AspNetCore.Components.Forms
              @using Microsoft.AspNetCore.Components.Routing
              @using Microsoft.AspNetCore.Components.Web
              @using static Microsoft.AspNetCore.Components.Web.RenderMode
              @using Microsoft.AspNetCore.Components.Web.Virtualization
              @using Microsoft.JSInterop
              @using {{configuration.AppName}}.Shared
              @using {{configuration.AppName}}.Web
              @using {{configuration.AppName}}.Web.Components
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/{configuration.AppName}.Web.csproj",
            $$""""
            <Project Sdk="Microsoft.NET.Sdk.Web">
              
                <PropertyGroup>
                  <TargetFramework>net9.0</TargetFramework>
                  <Nullable>enable</Nullable>
                  <ImplicitUsings>enable</ImplicitUsings>
                </PropertyGroup>
              
                <ItemGroup>
                  <ProjectReference Include="..\{{configuration.AppName}}.Shared\{{configuration.AppName}}.Shared.csproj" />
                </ItemGroup>
              
              </Project>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Program.cs",
            $$""""
            using {{configuration.AppName}}.Web.Components;
              using {{configuration.AppName}}.Shared.Services;
              using {{configuration.AppName}}.Web.Services;
              
              var builder = WebApplication.CreateBuilder(args);
              
              // Add services to the container.
              builder.Services.AddRazorComponents()
                  .AddInteractiveServerComponents();
              
              // Add device-specific services used by the {{configuration.AppName}}.Shared project
              builder.Services.AddSingleton<IFormFactor, FormFactor>();
              
              var app = builder.Build();
              
              // Configure the HTTP request pipeline.
              if (!app.Environment.IsDevelopment())
              {
                  app.UseExceptionHandler("/Error", createScopeForErrors: true);
                  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                  app.UseHsts();
              }
              
              app.UseHttpsRedirection();
              
              app.UseStaticFiles();
              app.UseAntiforgery();
              
              app.MapRazorComponents<App>()
                  .AddInteractiveServerRenderMode()
                  .AddAdditionalAssemblies(typeof({{configuration.AppName}}.Shared._Imports).Assembly);
              
              app.Run();
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Properties/launchSettings.json",
            $$""""
            {
                "$schema": "https://json.schemastore.org/launchsettings.json",
                  "iisSettings": {
                    "windowsAuthentication": false,
                    "anonymousAuthentication": true,
                    "iisExpress": {
                      "applicationUrl": "http://localhost:51096",
                      "sslPort": 44376
                    }
                  },
                  "profiles": {
                    "http": {
                      "commandName": "Project",
                      "dotnetRunMessages": true,
                      "launchBrowser": true,
                      "applicationUrl": "http://localhost:5159",
                      "environmentVariables": {
                        "ASPNETCORE_ENVIRONMENT": "Development"
                      }
                    },
                    "https": {
                      "commandName": "Project",
                      "dotnetRunMessages": true,
                      "launchBrowser": true,
                      "applicationUrl": "https://localhost:7173;http://localhost:5159",
                      "environmentVariables": {
                        "ASPNETCORE_ENVIRONMENT": "Development"
                      }
                    },
                    "IIS Express": {
                      "commandName": "IISExpress",
                      "launchBrowser": true,
                      "environmentVariables": {
                        "ASPNETCORE_ENVIRONMENT": "Development"
                      }
                    }
                  }
                }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/Services/FormFactor.cs",
            $$""""
            using {{configuration.AppName}}.Shared.Services;
              
              namespace {{configuration.AppName}}.Web.Services;
              
              public class FormFactor : IFormFactor
              {
                  public string GetFormFactor()
                  {
                      return "Web";
                  }
              
                  public string GetPlatform()
                  {
                      return Environment.OSVersion.ToString();
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/appsettings.Development.json",
            $$""""
            {
                "Logging": {
                  "LogLevel": {
                    "Default": "Information",
                    "Microsoft.AspNetCore": "Warning"
                  }
                }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.Web/appsettings.json",
            $$""""
            {
                "Logging": {
                  "LogLevel": {
                    "Default": "Information",
                    "Microsoft.AspNetCore": "Warning"
                  }
                },
                "AllowedHosts": "*"
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}.sln",
            $$""""

              Microsoft Visual Studio Solution File, Format Version 12.00
              # Visual Studio Version 17
              VisualStudioVersion = 17.5.002.0
              MinimumVisualStudioVersion = 10.0.40219.1
              Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "{{configuration.AppName}}", "{{configuration.AppName}}\{{configuration.AppName}}.csproj", "{E3338D37-FF50-4A34-96BD-2716ED93F1E2}"
              EndProject
              Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "{{configuration.AppName}}.Shared", "{{configuration.AppName}}.Shared\{{configuration.AppName}}.Shared.csproj", "{1AA5F22B-62F8-414F-AE50-635E99EB3F76}"
              EndProject
              Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "{{configuration.AppName}}.Web", "{{configuration.AppName}}.Web\{{configuration.AppName}}.Web.csproj", "{C2800ABA-8C19-4553-A552-BFF679BEB039}"
              EndProject
              Global
              	GlobalSection(SolutionConfigurationPlatforms) = preSolution
              		Debug|Any CPU = Debug|Any CPU
              		Debug|ARM64 = Debug|ARM64
              		Debug|x64 = Debug|x64
              		Debug|x86 = Debug|x86
              		Release|Any CPU = Release|Any CPU
              		Release|ARM64 = Release|ARM64
              		Release|x64 = Release|x64
              		Release|x86 = Release|x86
              	EndGlobalSection
              	GlobalSection(ProjectConfigurationPlatforms) = postSolution
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|Any CPU.Build.0 = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|ARM64.ActiveCfg = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|ARM64.Build.0 = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|x64.ActiveCfg = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|x64.Build.0 = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|x86.ActiveCfg = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Debug|x86.Build.0 = Debug|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|Any CPU.ActiveCfg = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|Any CPU.Build.0 = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|ARM64.ActiveCfg = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|ARM64.Build.0 = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|x64.ActiveCfg = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|x64.Build.0 = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|x86.ActiveCfg = Release|Any CPU
              		{1AA5F22B-62F8-414F-AE50-635E99EB3F76}.Release|x86.Build.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|Any CPU.Build.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|Any CPU.Deploy.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|ARM64.ActiveCfg = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|ARM64.Build.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|ARM64.Deploy.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x64.ActiveCfg = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x64.Build.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x64.Deploy.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x86.ActiveCfg = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x86.Build.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Debug|x86.Deploy.0 = Debug|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|Any CPU.ActiveCfg = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|Any CPU.Build.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|Any CPU.Deploy.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|ARM64.ActiveCfg = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|ARM64.Build.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|ARM64.Deploy.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x64.ActiveCfg = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x64.Build.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x64.Deploy.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x86.ActiveCfg = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x86.Build.0 = Release|Any CPU
              		{C2800ABA-8C19-4553-A552-BFF679BEB039}.Release|x86.Deploy.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|Any CPU.Build.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|Any CPU.Deploy.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|ARM64.ActiveCfg = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|ARM64.Build.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|ARM64.Deploy.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x64.ActiveCfg = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x64.Build.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x64.Deploy.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x86.ActiveCfg = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x86.Build.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Debug|x86.Deploy.0 = Debug|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|Any CPU.ActiveCfg = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|Any CPU.Build.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|Any CPU.Deploy.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|ARM64.ActiveCfg = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|ARM64.Build.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|ARM64.Deploy.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x64.ActiveCfg = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x64.Build.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x64.Deploy.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x86.ActiveCfg = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x86.Build.0 = Release|Any CPU
              		{E3338D37-FF50-4A34-96BD-2716ED93F1E2}.Release|x86.Deploy.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|Any CPU.Build.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|Any CPU.Deploy.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|ARM64.ActiveCfg = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|ARM64.Build.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|ARM64.Deploy.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x64.ActiveCfg = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x64.Build.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x64.Deploy.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x86.ActiveCfg = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x86.Build.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Debug|x86.Deploy.0 = Debug|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|Any CPU.ActiveCfg = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|Any CPU.Build.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|Any CPU.Deploy.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|ARM64.ActiveCfg = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|ARM64.Build.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|ARM64.Deploy.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x64.ActiveCfg = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x64.Build.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x64.Deploy.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x86.ActiveCfg = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x86.Build.0 = Release|Any CPU
              		{9E30318E-74DD-491B-9BAF-814DC9E892B8}.Release|x86.Deploy.0 = Release|Any CPU
              	EndGlobalSection
              	GlobalSection(SolutionProperties) = preSolution
              		HideSolutionNode = FALSE
              	EndGlobalSection
              	GlobalSection(ExtensibilityGlobals) = postSolution
              		SolutionGuid = {20E6FD03-9002-4EBA-ABF2-9DDE2C488842}
              	EndGlobalSection
              EndGlobal
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/App.xaml",
            $$""""
            <?xml version="1.0" encoding="UTF-8" ?>
              <Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                           xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                           xmlns:local="clr-namespace:{{configuration.AppName}}"
                           x:Class="{{configuration.AppName}}.App">
                  <Application.Resources>
                      <ResourceDictionary>
              
                          <Color x:Key="PageBackgroundColor">#512bdf</Color>
                          <Color x:Key="PrimaryTextColor">White</Color>
              
                          <Style TargetType="Label">
                              <Setter Property="TextColor" Value="{DynamicResource PrimaryTextColor}" />
                              <Setter Property="FontFamily" Value="OpenSansRegular" />
                          </Style>
              
                          <Style TargetType="Button">
                              <Setter Property="TextColor" Value="{DynamicResource PrimaryTextColor}" />
                              <Setter Property="FontFamily" Value="OpenSansRegular" />
                              <Setter Property="BackgroundColor" Value="#2b0b98" />
                              <Setter Property="Padding" Value="14,10" />
                          </Style>
              
                      </ResourceDictionary>
                  </Application.Resources>
              </Application>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/App.xaml.cs",
            $$""""
            namespace {{configuration.AppName}};
              
              public partial class App : Application
              {
                  public App()
                  {
                      InitializeComponent();
                  }
              
                  protected override Window CreateWindow(IActivationState? activationState)
                  {
                      return new Window(new MainPage());
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Components/_Imports.razor",
            $$""""
            @using System.Net.Http
              @using System.Net.Http.Json
              @using Microsoft.AspNetCore.Components.Forms
              @using Microsoft.AspNetCore.Components.Routing
              @using Microsoft.AspNetCore.Components.Web
              @using Microsoft.AspNetCore.Components.Web.Virtualization
              @using Microsoft.JSInterop
              @using {{configuration.AppName}}
              @using {{configuration.AppName}}.Components
              @using {{configuration.AppName}}.Shared
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/MainPage.xaml",
            $$""""
            <?xml version="1.0" encoding="utf-8" ?>
              <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                           xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                           xmlns:local="clr-namespace:{{configuration.AppName}}"
                           xmlns:shared="clr-namespace:{{configuration.AppName}}.Shared;assembly={{configuration.AppName}}.Shared"
                           x:Class="{{configuration.AppName}}.MainPage"
                           BackgroundColor="{DynamicResource PageBackgroundColor}">
              
                  <BlazorWebView x:Name="blazorWebView" HostPage="wwwroot/index.html">
                      <BlazorWebView.RootComponents>
                          <RootComponent Selector="#app" ComponentType="{x:Type shared:Routes}" />
                      </BlazorWebView.RootComponents>
                  </BlazorWebView>
              
              </ContentPage>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/MainPage.xaml.cs",
            $$""""
            namespace {{configuration.AppName}};
              
              public partial class MainPage : ContentPage
              {
                  public MainPage()
                  {
                      InitializeComponent();
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/MauiProgram.cs",
            $$""""
            using Microsoft.Extensions.Logging;
              using {{configuration.AppName}}.Shared.Services;
              using {{configuration.AppName}}.Services;
              
              namespace {{configuration.AppName}};
              
              public static class MauiProgram
              {
                  public static MauiApp CreateMauiApp()
                  {
                      var builder = MauiApp.CreateBuilder();
                      builder
                          .UseMauiApp<App>()
                          .ConfigureFonts(fonts =>
                          {
                              fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                          });
              
                      // Add device-specific services used by the {{configuration.AppName}}.Shared project
                      builder.Services.AddSingleton<IFormFactor, FormFactor>();
              
                      builder.Services.AddMauiBlazorWebView();
              
              #if DEBUG
                      builder.Services.AddBlazorWebViewDeveloperTools();
                      builder.Logging.AddDebug();
              #endif
              
                      return builder.Build();
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/{configuration.AppName}.csproj",
            $$""""
            <Project Sdk="Microsoft.NET.Sdk.Razor">
              
                <PropertyGroup>
                  <TargetFrameworks>net9.0-android;net9.0-ios;net9.0-maccatalyst</TargetFrameworks>
                  <TargetFrameworks Condition="$([MSBuild]::IsOSPlatform('windows'))">$(TargetFrameworks);net9.0-windows10.0.19041.0</TargetFrameworks>
                  <!-- Uncomment to also build the tizen app. You will need to install tizen by following this: https://github.com/Samsung/Tizen.NET -->
                  <!-- <TargetFrameworks>$(TargetFrameworks);net9.0-tizen</TargetFrameworks> -->
              
                  <!-- Note for MacCatalyst:
                    The default runtime is maccatalyst-x64, except in Release config, in which case the default is maccatalyst-x64;maccatalyst-arm64.
                    When specifying both architectures, use the plural <RuntimeIdentifiers> instead of the singular <RuntimeIdentifier>.
                    The Mac App Store will NOT accept apps with ONLY maccatalyst-arm64 indicated;
                    either BOTH runtimes must be indicated or ONLY macatalyst-x64. -->
                  <!-- For example: <RuntimeIdentifiers>maccatalyst-x64;maccatalyst-arm64</RuntimeIdentifiers> -->
              
                  <OutputType>Exe</OutputType>
                  <RootNamespace>{{configuration.AppName}}</RootNamespace>
                  <UseMaui>true</UseMaui>
                  <SingleProject>true</SingleProject>
                  <ImplicitUsings>enable</ImplicitUsings>
                  <EnableDefaultCssItems>false</EnableDefaultCssItems>
                  <Nullable>enable</Nullable>
              
                  <!-- Display name -->
                  <ApplicationTitle>{{configuration.AppName}}</ApplicationTitle>
              
                  <!-- App Identifier -->
                  <ApplicationId>{{configuration.ApplicationId}}</ApplicationId>
              
                  <!-- Versions -->
                  <ApplicationDisplayVersion>1.0</ApplicationDisplayVersion>
                  <ApplicationVersion>1</ApplicationVersion>
              
                  <!-- To develop, package, and publish an app to the Microsoft Store, see: https://aka.ms/MauiTemplateUnpackaged -->
                  <WindowsPackageType>None</WindowsPackageType>
              
                  <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'ios'">15.0</SupportedOSPlatformVersion>
                  <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'maccatalyst'">15.0</SupportedOSPlatformVersion>
                  <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">24.0</SupportedOSPlatformVersion>
                  <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</SupportedOSPlatformVersion>
                  <TargetPlatformMinVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'windows'">10.0.17763.0</TargetPlatformMinVersion>
                  <SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'tizen'">6.5</SupportedOSPlatformVersion>
                </PropertyGroup>
              
                <ItemGroup>
                  <!-- App Icon -->
                  <MauiIcon Include="Resources\AppIcon\appicon.svg" ForegroundFile="Resources\AppIcon\appiconfg.svg" Color="#512BD4" />
              
                  <!-- Splash Screen -->
                  <MauiSplashScreen Include="Resources\Splash\splash.svg" Color="#512BD4" BaseSize="128,128" />
              
                  <!-- Images -->
                  <MauiImage Include="Resources\Images\*" />
                  <MauiImage Update="Resources\Images\dotnet_bot.svg" BaseSize="168,208" />
              
                  <!-- Custom Fonts -->
                  <MauiFont Include="Resources\Fonts\*" />
              
                  <!-- Raw Assets (also remove the "Resources\Raw" prefix) -->
                  <MauiAsset Include="Resources\Raw\**" LogicalName="%(RecursiveDir)%(Filename)%(Extension)" />
                </ItemGroup>
              
                <ItemGroup>
                  <PackageReference Include="Microsoft.Maui.Controls" Version="$(MauiVersion)" />
                  <PackageReference Include="Microsoft.AspNetCore.Components.WebView.Maui" Version="$(MauiVersion)" />
                  <PackageReference Include="Microsoft.Extensions.Logging.Debug" Version="9.0.0-rc.1.24431.7" />
                </ItemGroup>
              
                <ItemGroup>
                  <ProjectReference Include="..\{{configuration.AppName}}.Shared\{{configuration.AppName}}.Shared.csproj" />
                </ItemGroup>
              
              </Project>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Android/AndroidManifest.xml",
            $$""""
            <?xml version="1.0" encoding="utf-8"?>
              <manifest xmlns:android="http://schemas.android.com/apk/res/android">
                  <application android:allowBackup="true" android:icon="@mipmap/appicon" android:roundIcon="@mipmap/appicon_round" android:supportsRtl="true"></application>
                  <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
                  <uses-permission android:name="android.permission.INTERNET" />
              </manifest>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Android/MainActivity.cs",
            $$""""
            using Android.App;
              using Android.Content.PM;
              using Android.OS;
              
              namespace {{configuration.AppName}};
              
              [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
              public class MainActivity : MauiAppCompatActivity
              {
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Android/MainApplication.cs",
            $$""""
            using Android.App;
              using Android.Runtime;
              
              namespace {{configuration.AppName}};
              
              [Application]
              public class MainApplication : MauiApplication
              {
                  public MainApplication(IntPtr handle, JniHandleOwnership ownership)
                      : base(handle, ownership)
                  {
                  }
              
                  protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Android/Resources/values/colors.xml",
            $$""""
            <?xml version="1.0" encoding="utf-8"?>
              <resources>
                  <color name="colorPrimary">#512BD4</color>
                  <color name="colorPrimaryDark">#2B0B98</color>
                  <color name="colorAccent">#2B0B98</color>
              </resources>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/MacCatalyst/AppDelegate.cs",
            $$""""
            using Foundation;
              
              namespace {{configuration.AppName}};
              
              [Register("AppDelegate")]
              public class AppDelegate : MauiUIApplicationDelegate
              {
                  protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/MacCatalyst/Entitlements.plist",
            $$""""
            <?xml version="1.0" encoding="UTF-8"?>
              <!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
              <plist version="1.0">
                  <!-- See https://aka.ms/maui-publish-app-store#add-entitlements for more information about adding entitlements.-->
                  <dict>
                      <!-- App Sandbox must be enabled to distribute a MacCatalyst app through the Mac App Store. -->
                      <key>com.apple.security.app-sandbox</key>
                      <true/>
                      <!-- When App Sandbox is enabled, this value is required to open outgoing network connections. -->
                      <key>com.apple.security.network.client</key>
                      <true/>
                  </dict>
              </plist>
              
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/MacCatalyst/Info.plist",
            $$""""
            <?xml version="1.0" encoding="UTF-8"?>
              <!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
              <plist version="1.0">
              <dict>
                  <!-- The Mac App Store requires you specify if the app uses encryption. -->
                  <!-- Please consult https://developer.apple.com/documentation/bundleresources/information_property_list/itsappusesnonexemptencryption -->
                  <!-- <key>ITSAppUsesNonExemptEncryption</key> -->
                  <!-- Please indicate <true/> or <false/> here. -->
              
                  <!-- Specify the category for your app here. -->
                  <!-- Please consult https://developer.apple.com/documentation/bundleresources/information_property_list/lsapplicationcategorytype -->
                  <!-- <key>LSApplicationCategoryType</key> -->
                  <!-- <string>public.app-category.YOUR-CATEGORY-HERE</string> -->
                  <key>UIDeviceFamily</key>
                  <array>
                      <integer>2</integer>
                  </array>
                  <key>UIRequiredDeviceCapabilities</key>
                  <array>
                      <string>arm64</string>
                  </array>
                  <key>UISupportedInterfaceOrientations</key>
                  <array>
                      <string>UIInterfaceOrientationPortrait</string>
                      <string>UIInterfaceOrientationLandscapeLeft</string>
                      <string>UIInterfaceOrientationLandscapeRight</string>
                  </array>
                  <key>UISupportedInterfaceOrientations~ipad</key>
                  <array>
                      <string>UIInterfaceOrientationPortrait</string>
                      <string>UIInterfaceOrientationPortraitUpsideDown</string>
                      <string>UIInterfaceOrientationLandscapeLeft</string>
                      <string>UIInterfaceOrientationLandscapeRight</string>
                  </array>
                  <key>XSAppIconAssets</key>
                  <string>Assets.xcassets/appicon.appiconset</string>
              </dict>
              </plist>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/MacCatalyst/Program.cs",
            $$""""
            using ObjCRuntime;
              using UIKit;
              
              namespace {{configuration.AppName}};
              
              public class Program
              {
                  // This is the main entry point of the application.
                  static void Main(string[] args)
                  {
                      // if you want to use a different Application Delegate class from "AppDelegate"
                      // you can specify it here.
                      UIApplication.Main(args, null, typeof(AppDelegate));
                  }
              }
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Tizen/Main.cs",
            $$""""
            using System;
              using Microsoft.Maui;
              using Microsoft.Maui.Hosting;
              
              namespace {{configuration.AppName}};
              
              class Program : MauiApplication
              {
                  protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
              
                  static void Main(string[] args)
                  {
                      var app = new Program();
                      app.Run(args);
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Tizen/tizen-manifest.xml",
            $$""""
            <?xml version="1.0" encoding="utf-8"?>
              <manifest package="maui-application-id-placeholder" version="0.0.0" api-version="8" xmlns="http://tizen.org/ns/packages">
                <profile name="common" />
                <ui-application appid="maui-application-id-placeholder" exec="{{configuration.AppName}}.dll" multiple="false" nodisplay="false" taskmanage="true" type="dotnet" launch_mode="single">
                  <label>maui-application-title-placeholder</label>
                  <icon>maui-appicon-placeholder</icon>
                  <metadata key="http://tizen.org/metadata/prefer_dotnet_aot" value="true" />
                </ui-application>
                <shortcut-list />
                <privileges>
                  <privilege>http://tizen.org/privilege/internet</privilege>
                </privileges> 
                <dependencies />
                <provides-appdefined-privileges />
              </manifest>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Windows/App.xaml",
            $$""""
            <maui:MauiWinUIApplication
                  x:Class="{{configuration.AppName}}.WinUI.App"
                  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                  xmlns:maui="using:Microsoft.Maui"
                  xmlns:local="using:{{configuration.AppName}}.WinUI">
              
              </maui:MauiWinUIApplication>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Windows/App.xaml.cs",
            $$""""
            using Microsoft.UI.Xaml;
              
              // To learn more about WinUI, the WinUI project structure,
              // and more about our project templates, see: http://aka.ms/winui-project-info.
              
              namespace {{configuration.AppName}}.WinUI;
              
              /// <summary>
              /// Provides application-specific behavior to supplement the default Application class.
              /// </summary>
              public partial class App : MauiWinUIApplication
              {
                  /// <summary>
                  /// Initializes the singleton application object.  This is the first line of authored code
                  /// executed, and as such is the logical equivalent of main() or WinMain().
                  /// </summary>
                  public App()
                  {
                      this.InitializeComponent();
                  }
              
                  protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
              }
              
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Windows/Package.appxmanifest",
            $$""""
            <?xml version="1.0" encoding="utf-8"?>
              <Package
                xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10"
                xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10"
                xmlns:mp="http://schemas.microsoft.com/appx/2014/phone/manifest"
                xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"
                IgnorableNamespaces="uap rescap">
              
                <Identity Name="maui-package-name-placeholder" Publisher="CN=User Name" Version="0.0.0.0" />
              
                <mp:PhoneIdentity PhoneProductId="975F1018-C57A-4ADD-ABCF-AEC70612898B" PhonePublisherId="00000000-0000-0000-0000-000000000000"/>
              
                <Properties>
                  <DisplayName>$placeholder$</DisplayName>
                  <PublisherDisplayName>User Name</PublisherDisplayName>
                  <Logo>$placeholder$.png</Logo>
                </Properties>
              
                <Dependencies>
                  <TargetDeviceFamily Name="Windows.Universal" MinVersion="10.0.17763.0" MaxVersionTested="10.0.19041.0" />
                  <TargetDeviceFamily Name="Windows.Desktop" MinVersion="10.0.17763.0" MaxVersionTested="10.0.19041.0" />
                </Dependencies>
              
                <Resources>
                  <Resource Language="x-generate" />
                </Resources>
              
                <Applications>
                  <Application Id="App" Executable="$targetnametoken$.exe" EntryPoint="$targetentrypoint$">
                    <uap:VisualElements
                      DisplayName="$placeholder$"
                      Description="$placeholder$"
                      Square150x150Logo="$placeholder$.png"
                      Square44x44Logo="$placeholder$.png"
                      BackgroundColor="transparent">
                      <uap:DefaultTile Square71x71Logo="$placeholder$.png" Wide310x150Logo="$placeholder$.png" Square310x310Logo="$placeholder$.png" />
                      <uap:SplashScreen Image="$placeholder$.png" />
                    </uap:VisualElements>
                  </Application>
                </Applications>
              
                <Capabilities>
                  <rescap:Capability Name="runFullTrust" />
                </Capabilities>
              
              </Package>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/Windows/app.manifest",
            $$""""
            <?xml version="1.0" encoding="utf-8"?>
              <assembly manifestVersion="1.0" xmlns="urn:schemas-microsoft-com:asm.v1">
                <assemblyIdentity version="1.0.0.0" name="{{configuration.AppName}}.WinUI.app"/>
              
                <application xmlns="urn:schemas-microsoft-com:asm.v3">
                  <windowsSettings>
                    <!-- The combination of below two tags have the following effect:
                         1) Per-Monitor for >= Windows 10 Anniversary Update
                         2) System < Windows 10 Anniversary Update
                    -->
                    <dpiAware xmlns="http://schemas.microsoft.com/SMI/2005/WindowsSettings">true/PM</dpiAware>
                    <dpiAwareness xmlns="http://schemas.microsoft.com/SMI/2016/WindowsSettings">PerMonitorV2, PerMonitor</dpiAwareness>
                  </windowsSettings>
                </application>
              </assembly>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/iOS/AppDelegate.cs",
            $$""""
            using Foundation;
              
              namespace {{configuration.AppName}};
              
              [Register("AppDelegate")]
              public class AppDelegate : MauiUIApplicationDelegate
              {
                  protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/iOS/Info.plist",
            $$""""
            <?xml version="1.0" encoding="UTF-8"?>
              <!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
              <plist version="1.0">
              <dict>
                  <key>LSRequiresIPhoneOS</key>
                  <true/>
                  <key>UIDeviceFamily</key>
                  <array>
                      <integer>1</integer>
                      <integer>2</integer>
                  </array>
                  <key>UIRequiredDeviceCapabilities</key>
                  <array>
                      <string>arm64</string>
                  </array>
                  <key>UISupportedInterfaceOrientations</key>
                  <array>
                      <string>UIInterfaceOrientationPortrait</string>
                      <string>UIInterfaceOrientationLandscapeLeft</string>
                      <string>UIInterfaceOrientationLandscapeRight</string>
                  </array>
                  <key>UISupportedInterfaceOrientations~ipad</key>
                  <array>
                      <string>UIInterfaceOrientationPortrait</string>
                      <string>UIInterfaceOrientationPortraitUpsideDown</string>
                      <string>UIInterfaceOrientationLandscapeLeft</string>
                      <string>UIInterfaceOrientationLandscapeRight</string>
                  </array>
                  <key>XSAppIconAssets</key>
                  <string>Assets.xcassets/appicon.appiconset</string>
              </dict>
              </plist>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Platforms/iOS/Program.cs",
            $$""""
            using ObjCRuntime;
              using UIKit;
              
              namespace {{configuration.AppName}};
              
              public class Program
              {
                  // This is the main entry point of the application.
                  static void Main(string[] args)
                  {
                      // if you want to use a different Application Delegate class from "AppDelegate"
                      // you can specify it here.
                      UIApplication.Main(args, null, typeof(AppDelegate));
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Properties/launchSettings.json",
            $$""""
            {
                "profiles": {
                  "Windows Machine": {
                    "commandName": "Project",
                    "nativeDebugging": false
                  }
                }
              }
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Resources/AppIcon/appicon.svg",
            $$""""
            <?xml version="1.0" encoding="UTF-8" standalone="no"?>
              <svg width="456" height="456" viewBox="0 0 456 456" version="1.1" xmlns="http://www.w3.org/2000/svg">
                  <rect x="0" y="0" width="456" height="456" fill="#512BD4" />
              </svg>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Resources/AppIcon/appiconfg.svg",
            $$""""
            <?xml version="1.0" encoding="UTF-8" standalone="no"?>
              <!DOCTYPE svg PUBLIC "-//W3C//DTD SVG 1.1//EN" "http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd">
              <svg width="456" height="456" viewBox="0 0 456 456" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" xml:space="preserve" xmlns:serif="http://www.serif.com/" style="fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;">
                  <path d="m 105.50037,281.60863 c -2.70293,0 -5.00091,-0.90042 -6.893127,-2.70209 -1.892214,-1.84778 -2.837901,-4.04181 -2.837901,-6.58209 0,-2.58722 0.945687,-4.80389 2.837901,-6.65167 1.892217,-1.84778 4.190197,-2.77167 6.893127,-2.77167 2.74819,0 5.06798,0.92389 6.96019,2.77167 1.93749,1.84778 2.90581,4.06445 2.90581,6.65167 0,2.54028 -0.96832,4.73431 -2.90581,6.58209 -1.89221,1.80167 -4.212,2.70209 -6.96019,2.70209 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="M 213.56111,280.08446 H 195.99044 L 149.69953,207.0544 c -1.17121,-1.84778 -2.14037,-3.76515 -2.90581,-5.75126 h -0.40578 c 0.36051,2.12528 0.54076,6.67515 0.54076,13.6496 v 65.13172 h -15.54349 v -99.36009 h 18.71925 l 44.7374,71.29798 c 1.89222,2.95695 3.1087,4.98917 3.64945,6.09751 h 0.26996 c -0.45021,-2.6325 -0.67573,-7.09015 -0.67573,-13.37293 v -64.02256 h 15.47557 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="m 289.25134,280.08446 h -54.40052 v -99.36009 h 52.23835 v 13.99669 h -36.15411 v 28.13085 h 33.31621 v 13.9271 h -33.31621 v 29.37835 h 38.31628 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="M 366.56466,194.72106 H 338.7222 v 85.3634 h -16.08423 v -85.3634 h -27.77455 v -13.99669 h 71.70124 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
              </svg>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Resources/Images/dotnet_bot.svg",
            $$""""
            <svg width="419" height="519" viewBox="0 0 419 519" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M284.432 247.568L284.004 221.881C316.359 221.335 340.356 211.735 355.308 193.336C382.408 159.996 372.893 108.183 372.786 107.659L398.013 102.831C398.505 105.432 409.797 167.017 375.237 209.53C355.276 234.093 324.719 246.894 284.432 247.568Z" fill="#8A6FE8"/>
              <path d="M331.954 109.36L361.826 134.245C367.145 138.676 375.055 137.959 379.497 132.639C383.928 127.32 383.211 119.41 377.891 114.969L348.019 90.0842C342.7 85.6531 334.79 86.3702 330.348 91.6896C325.917 97.0197 326.634 104.929 331.954 109.36Z" fill="#8A6FE8"/>
              <path d="M407.175 118.062L417.92 94.2263C420.735 87.858 417.856 80.4087 411.488 77.5831C405.12 74.7682 397.67 77.6473 394.845 84.0156L383.831 108.461L407.175 118.062Z" fill="#8A6FE8"/>
              <path d="M401.363 105.175L401.234 69.117C401.181 62.1493 395.498 56.541 388.53 56.5945C381.562 56.648 375.954 62.3313 376.007 69.2989L376.018 96.11L401.363 105.175Z" fill="#8A6FE8"/>
              <path d="M386.453 109.071L378.137 73.9548C376.543 67.169 369.757 62.9628 362.971 64.5575C356.185 66.1523 351.979 72.938 353.574 79.7237L362.04 115.482L386.453 109.071Z" fill="#8A6FE8"/>
              <path d="M381.776 142.261C396.359 142.261 408.181 130.44 408.181 115.857C408.181 101.274 396.359 89.4527 381.776 89.4527C367.194 89.4527 355.372 101.274 355.372 115.857C355.372 130.44 367.194 142.261 381.776 142.261Z" fill="url(#paint0_radial)"/>
              <path d="M248.267 406.979C248.513 384.727 245.345 339.561 222.376 301.736L199.922 315.372C220.76 349.675 222.323 389.715 221.841 407.182C221.798 408.627 235.263 409.933 248.267 406.979Z" fill="url(#paint1_linear)"/>
              <path d="M221.841 406.936L242.637 406.84L262.052 518.065L220.311 518.258C217.132 518.269 214.724 515.711 214.938 512.532L221.841 406.936Z" fill="#522CD5"/>
              <path d="M306.566 488.814C310.173 491.661 310.109 495.782 309.831 500.127L308.964 513.452C308.803 515.839 306.727 517.798 304.34 517.809L260.832 518.012C258.125 518.023 256.08 515.839 256.262 513.142L256.551 499.335C256.883 494.315 255.192 492.474 251.307 487.744C244.649 479.663 224.967 435.62 226.84 406.925L248.256 406.829C249.691 423.858 272.167 461.682 306.566 488.814Z" fill="url(#paint2_linear)"/>
              <path d="M309.82 500.127C310.023 497.088 310.077 494.176 308.889 491.715L254.635 491.961C256.134 494.166 256.765 496.092 256.562 499.314L256.273 513.121C256.091 515.828 258.146 518.012 260.843 517.99L304.34 517.798C306.727 517.787 308.803 515.828 308.964 513.442L309.82 500.127Z" fill="url(#paint3_radial)"/>
              <path d="M133.552 407.471C133.103 385.22 135.864 340.021 158.49 301.993L181.073 315.425C160.545 349.921 159.346 389.972 159.989 407.428C160.042 408.884 146.578 410.318 133.552 407.471Z" fill="url(#paint4_linear)"/>
              <path d="M110.798 497.152C110.765 494.187 111.204 491.575 112.457 487.23C131.882 434.132 133.52 407.364 133.52 407.364L159.999 407.246C159.999 407.246 161.819 433.512 181.716 486.427C183.289 490.195 183.471 493.641 183.674 496.831L183.792 513.816C183.803 516.374 181.716 518.483 179.158 518.494L177.873 518.504L116.781 518.782L115.496 518.793C112.927 518.804 110.83 516.728 110.819 514.159L110.798 497.152Z" fill="url(#paint5_linear)"/>
              <path d="M110.798 497.152C110.798 496.67 110.808 496.199 110.83 495.739C110.969 494.262 111.643 492.603 114.875 492.582L180.207 492.282C182.561 492.367 183.343 494.176 183.589 495.311C183.621 495.814 183.664 496.328 183.696 496.82L183.813 513.806C183.824 515.411 183.011 516.824 181.769 517.669C181.031 518.172 180.132 518.472 179.179 518.483L177.895 518.494L116.802 518.772L115.528 518.782C114.244 518.793 113.077 518.269 112.232 517.434C111.386 516.599 110.862 515.432 110.851 514.148L110.798 497.152Z" fill="url(#paint6_radial)"/>
              <path d="M314.979 246.348C324.162 210.407 318.008 181.777 318.008 181.777L326.452 181.734L326.656 181.574C314.262 115.75 256.326 66.0987 186.949 66.4198C108.796 66.773 45.7233 130.424 46.0765 208.577C46.4297 286.731 110.08 349.803 188.234 349.45C249.905 349.172 302.178 309.474 321.304 254.343C321.872 251.999 321.797 247.804 314.979 246.348Z" fill="url(#paint7_radial)"/>
              <path d="M310.237 279.035L65.877 280.148C71.3998 289.428 77.95 298.012 85.3672 305.761L290.972 304.829C298.336 297.005 304.8 288.368 310.237 279.035Z" fill="#D8CFF7"/>
              <path d="M235.062 312.794L280.924 312.585L280.74 272.021L234.877 272.23L235.062 312.794Z" fill="#512BD4"/>
              <path d="M243.001 297.626C242.691 297.626 242.434 297.53 242.22 297.327C242.006 297.123 241.899 296.866 241.899 296.588C241.899 296.299 242.006 296.042 242.22 295.839C242.434 295.625 242.691 295.528 243.001 295.528C243.312 295.528 243.568 295.635 243.782 295.839C243.996 296.042 244.114 296.299 244.114 296.588C244.114 296.877 244.007 297.123 243.793 297.327C243.568 297.519 243.312 297.626 243.001 297.626Z" fill="white"/>
              <path d="M255.192 297.434H253.212L247.967 289.203C247.839 289 247.721 288.775 247.636 288.55H247.593C247.636 288.786 247.657 289.299 247.657 290.091L247.668 297.444H245.912L245.891 286.228H247.999L253.062 294.265C253.276 294.597 253.415 294.833 253.479 294.95H253.511C253.458 294.651 253.437 294.148 253.437 293.441L253.426 286.217H255.17L255.192 297.434Z" fill="white"/>
              <path d="M263.733 297.412L257.589 297.423L257.568 286.206L263.465 286.195V287.779L259.387 287.79L259.398 290.969L263.155 290.958V292.532L259.398 292.542L259.409 295.86L263.733 295.85V297.412Z" fill="white"/>
              <path d="M272.445 287.758L269.298 287.769L269.32 297.401H267.5L267.479 287.769L264.343 287.779V286.195L272.434 286.174L272.445 287.758Z" fill="white"/>
              <path d="M315.279 246.337C324.355 210.836 318.457 182.483 318.308 181.798L171.484 182.462C171.484 182.462 162.226 181.563 162.268 190.018C162.311 198.463 162.761 222.341 162.878 248.746C162.9 254.172 167.363 256.773 170.863 256.751C170.874 256.751 311.618 252.213 315.279 246.337Z" fill="url(#paint8_radial)"/>
              <path d="M227.685 246.798C227.685 246.798 250.183 228.827 254.571 225.499C258.959 222.17 262.812 221.977 266.869 225.445C270.925 228.913 293.616 246.498 293.616 246.498L227.685 246.798Z" fill="#A08BE8"/>
              <path d="M320.748 256.141C320.748 256.141 324.943 248.414 315.279 246.348C315.289 246.305 170.927 246.894 170.927 246.894C167.566 246.905 163.232 244.925 162.846 241.671C162.857 244.004 162.878 246.369 162.889 248.756C162.91 253.68 166.582 256.27 169.878 256.698C170.21 256.73 170.542 256.773 170.874 256.773L180.742 256.73L320.748 256.141Z" fill="#512BD4"/>
              <path d="M206.4 233.214C212.511 233.095 217.302 224.667 217.102 214.39C216.901 204.112 211.785 195.878 205.674 195.997C199.563 196.116 194.772 204.544 194.973 214.821C195.173 225.099 200.289 233.333 206.4 233.214Z" fill="#512BD4"/>
              <path d="M306.249 214.267C306.356 203.989 301.488 195.605 295.377 195.541C289.266 195.478 284.225 203.758 284.118 214.037C284.011 224.315 288.878 232.699 294.99 232.763C301.101 232.826 306.142 224.545 306.249 214.267Z" fill="#512BD4"/>
              <path d="M205.905 205.291C208.152 203.022 211.192 202.016 214.157 202.262C215.912 205.495 217.014 209.733 217.111 214.389C217.164 217.3 216.811 220.04 216.158 222.513C212.669 223.519 208.752 222.662 205.979 219.922C201.912 215.909 201.88 209.348 205.905 205.291Z" fill="#8065E0"/>
              <path d="M294.996 204.285C297.255 202.016 300.294 200.999 303.259 201.256C305.164 204.628 306.309 209.209 306.256 214.239C306.224 216.808 305.892 219.259 305.303 221.485C301.793 222.523 297.843 221.678 295.061 218.916C291.004 214.892 290.972 208.342 294.996 204.285Z" fill="#8065E0"/>
              <path d="M11.6342 357.017C10.9171 354.716 -5.72611 300.141 21.3204 258.903C36.9468 235.078 63.3083 221.035 99.6664 217.15L102.449 243.276C74.3431 246.273 54.4676 256.345 43.3579 273.202C23.0971 303.941 36.5722 348.733 36.7113 349.183L11.6342 357.017Z" fill="url(#paint9_linear)"/>
              <path d="M95.1498 252.802C109.502 252.802 121.137 241.167 121.137 226.815C121.137 212.463 109.502 200.828 95.1498 200.828C80.7976 200.828 69.1628 212.463 69.1628 226.815C69.1628 241.167 80.7976 252.802 95.1498 252.802Z" fill="url(#paint10_radial)"/>
              <path d="M72.0098 334.434L33.4683 329.307C26.597 328.397 20.2929 333.214 19.3725 340.085C18.4627 346.956 23.279 353.26 30.1504 354.181L68.6919 359.308C75.5632 360.217 81.8673 355.401 82.7878 348.53C83.6975 341.658 78.8705 335.344 72.0098 334.434Z" fill="#8A6FE8"/>
              <path d="M3.73535 367.185L7.35297 393.076C8.36975 399.968 14.7702 404.731 21.6629 403.725C28.5556 402.708 33.3185 396.308 32.3124 389.415L28.5984 362.861L3.73535 367.185Z" fill="#8A6FE8"/>
              <path d="M15.5194 374.988L34.849 405.427C38.6058 411.292 46.4082 413.005 52.2735 409.248C58.1387 405.491 59.8512 397.689 56.0945 391.823L41.7953 369.144L15.5194 374.988Z" fill="#8A6FE8"/>
              <path d="M26.0511 363.739L51.8026 389.019C56.7688 393.911 64.7532 393.846 69.6445 388.88C74.5358 383.914 74.4715 375.929 69.516 371.038L43.2937 345.297L26.0511 363.739Z" fill="#8A6FE8"/>
              <path d="M26.4043 381.912C40.987 381.912 52.8086 370.091 52.8086 355.508C52.8086 340.925 40.987 329.104 26.4043 329.104C11.8216 329.104 0 340.925 0 355.508C0 370.091 11.8216 381.912 26.4043 381.912Z" fill="url(#paint11_radial)"/>
              <path d="M184.73 63.6308L157.819 66.5892L158.561 38.5412L177.888 36.4178L184.73 63.6308Z" fill="#8A6FE8"/>
              <path d="M170.018 41.647C180.455 39.521 187.193 29.3363 185.067 18.8988C182.941 8.46126 172.757 1.72345 162.319 3.84944C151.882 5.97543 145.144 16.1601 147.27 26.5976C149.396 37.0351 159.58 43.773 170.018 41.647Z" fill="#D8CFF7"/>
              <path d="M196.885 79.385C198.102 79.2464 198.948 78.091 198.684 76.8997C195.851 64.2818 183.923 55.5375 170.773 56.9926C157.622 58.4371 147.886 69.5735 147.865 82.4995C147.863 83.7232 148.949 84.6597 150.168 84.5316L196.885 79.385Z" fill="url(#paint12_radial)"/>
              <defs>
              <radialGradient id="paint0_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(382.004 103.457) scale(26.4058)">
              <stop stop-color="#8065E0"/>
              <stop offset="1" stop-color="#512BD4"/>
              </radialGradient>
              <linearGradient id="paint1_linear" x1="214.439" y1="303.482" x2="236.702" y2="409.505" gradientUnits="userSpaceOnUse">
              <stop stop-color="#522CD5"/>
              <stop offset="0.4397" stop-color="#8A6FE8"/>
              </linearGradient>
              <linearGradient id="paint2_linear" x1="231.673" y1="404.144" x2="297.805" y2="522.048" gradientUnits="userSpaceOnUse">
              <stop stop-color="#522CD5"/>
              <stop offset="0.4397" stop-color="#8A6FE8"/>
              </linearGradient>
              <radialGradient id="paint3_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(280.957 469.555) rotate(-0.260742) scale(45.8326)">
              <stop offset="0.034" stop-color="#522CD5"/>
              <stop offset="0.9955" stop-color="#8A6FE8"/>
              </radialGradient>
              <linearGradient id="paint4_linear" x1="166.061" y1="303.491" x2="144.763" y2="409.709" gradientUnits="userSpaceOnUse">
              <stop stop-color="#522CD5"/>
              <stop offset="0.4397" stop-color="#8A6FE8"/>
              </linearGradient>
              <linearGradient id="paint5_linear" x1="146.739" y1="407.302" x2="147.246" y2="518.627" gradientUnits="userSpaceOnUse">
              <stop stop-color="#522CD5"/>
              <stop offset="0.4397" stop-color="#8A6FE8"/>
              </linearGradient>
              <radialGradient id="paint6_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(148.63 470.023) rotate(179.739) scale(50.2476)">
              <stop offset="0.034" stop-color="#522CD5"/>
              <stop offset="0.9955" stop-color="#8A6FE8"/>
              </radialGradient>
              <radialGradient id="paint7_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(219.219 153.929) rotate(179.739) scale(140.935)">
              <stop offset="0.4744" stop-color="#A08BE8"/>
              <stop offset="0.8618" stop-color="#8065E0"/>
              </radialGradient>
              <radialGradient id="paint8_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(314.861 158.738) rotate(179.739) scale(146.053)">
              <stop offset="0.0933" stop-color="#E1DFDD"/>
              <stop offset="0.6573" stop-color="white"/>
              </radialGradient>
              <linearGradient id="paint9_linear" x1="54.1846" y1="217.159" x2="54.1846" y2="357.022" gradientUnits="userSpaceOnUse">
              <stop offset="0.3344" stop-color="#9780E6"/>
              <stop offset="0.8488" stop-color="#8A6FE8"/>
              </linearGradient>
              <radialGradient id="paint10_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(90.3494 218.071) rotate(-0.260742) scale(25.9924)">
              <stop stop-color="#8065E0"/>
              <stop offset="1" stop-color="#512BD4"/>
              </radialGradient>
              <radialGradient id="paint11_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(25.805 345.043) scale(26.4106)">
              <stop stop-color="#8065E0"/>
              <stop offset="1" stop-color="#512BD4"/>
              </radialGradient>
              <radialGradient id="paint12_radial" cx="0" cy="0" r="1" gradientUnits="userSpaceOnUse" gradientTransform="translate(169.113 67.3662) rotate(-32.2025) scale(21.0773)">
              <stop stop-color="#8065E0"/>
              <stop offset="1" stop-color="#512BD4"/>
              </radialGradient>
              </defs>
              </svg>
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Resources/Raw/AboutAssets.txt",
            $$""""
            Any raw assets you want to be deployed with your application can be placed in
              this directory (and child directories). Deployment of the asset to your application
              is automatically handled by the following `MauiAsset` Build Action within your `.csproj`.
              
                  <MauiAsset Include="Resources\Raw\**" LogicalName="%(RecursiveDir)%(Filename)%(Extension)" />
              
              These files will be deployed with your package and will be accessible using Essentials:
              
                  async Task LoadMauiAsset()
                  {
                      using var stream = await FileSystem.OpenAppPackageFileAsync("AboutAssets.txt");
                      using var reader = new StreamReader(stream);
              
                      var contents = reader.ReadToEnd();
                  }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Resources/Splash/splash.svg",
            $$""""
            <?xml version="1.0" encoding="UTF-8" standalone="no"?>
              <!DOCTYPE svg PUBLIC "-//W3C//DTD SVG 1.1//EN" "http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd">
              <svg width="456" height="456" viewBox="0 0 456 456" version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" xml:space="preserve" xmlns:serif="http://www.serif.com/" style="fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;">
                  <path d="m 105.50037,281.60863 c -2.70293,0 -5.00091,-0.90042 -6.893127,-2.70209 -1.892214,-1.84778 -2.837901,-4.04181 -2.837901,-6.58209 0,-2.58722 0.945687,-4.80389 2.837901,-6.65167 1.892217,-1.84778 4.190197,-2.77167 6.893127,-2.77167 2.74819,0 5.06798,0.92389 6.96019,2.77167 1.93749,1.84778 2.90581,4.06445 2.90581,6.65167 0,2.54028 -0.96832,4.73431 -2.90581,6.58209 -1.89221,1.80167 -4.212,2.70209 -6.96019,2.70209 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="M 213.56111,280.08446 H 195.99044 L 149.69953,207.0544 c -1.17121,-1.84778 -2.14037,-3.76515 -2.90581,-5.75126 h -0.40578 c 0.36051,2.12528 0.54076,6.67515 0.54076,13.6496 v 65.13172 h -15.54349 v -99.36009 h 18.71925 l 44.7374,71.29798 c 1.89222,2.95695 3.1087,4.98917 3.64945,6.09751 h 0.26996 c -0.45021,-2.6325 -0.67573,-7.09015 -0.67573,-13.37293 v -64.02256 h 15.47557 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="m 289.25134,280.08446 h -54.40052 v -99.36009 h 52.23835 v 13.99669 h -36.15411 v 28.13085 h 33.31621 v 13.9271 h -33.31621 v 29.37835 h 38.31628 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
                  <path d="M 366.56466,194.72106 H 338.7222 v 85.3634 h -16.08423 v -85.3634 h -27.77455 v -13.99669 h 71.70124 z" style="fill:#ffffff;fill-rule:nonzero;stroke-width:0.838376" />
              </svg>
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/Services/FormFactor.cs",
            $$""""
            using {{configuration.AppName}}.Shared.Services;
              
              namespace {{configuration.AppName}}.Services;
              
              public class FormFactor : IFormFactor
              {
                  public string GetFormFactor()
                  {
                      return DeviceInfo.Idiom.ToString();
                  }
              
                  public string GetPlatform()
                  {
                      return DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/wwwroot/app.css",
            $$""""
            .status-bar-safe-area {
                  display: none;
              }
              
              @supports (-webkit-touch-callout: none) {
                  .status-bar-safe-area {
                      display: flex;
                      position: sticky;
                      top: 0;
                      height: env(safe-area-inset-top);
                      background-color: #f7f7f7;
                      width: 100%;
                      z-index: 1;
                  }
              
                  .flex-column, .navbar-brand {
                      padding-left: env(safe-area-inset-left);
                  }
              }
              
            """"
        );

        GraphQLOperations.AddFile(
            $"{configuration.OutputPath}/{configuration.AppName}/wwwroot/index.html",
            $$""""
            <!DOCTYPE html>
              <html lang="en">
              <head>
                  <meta charset="utf-8" />
                  <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no, viewport-fit=cover" />
                  <title>{{configuration.AppName}}</title>
                  <base href="/" />
                  {{CaretRef.New(new CaretTag("location", "Blazor/html/head"))}}
                  <link rel="stylesheet" href="_content/{{configuration.AppName}}.Shared/app.css" />
                  <link rel="stylesheet" href="app.css" />
                  <link rel="stylesheet" href="{{configuration.AppName}}.styles.css" />
                  <link rel="icon" href="data:,">
              </head>
              
              <body>
              
                  <div class="status-bar-safe-area"></div>
              
                  <div id="app">Loading...</div>
              
                  <script src="_framework/blazor.webview.js" autostart="false"></script>
              
              </body>
              
              </html>
            """"
        );
    }
}
