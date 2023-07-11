# Microservices

readme.md

## Running

```
PREFIX=samples/architecture/server/microservices/

PREFIX=.

dotnet watch build \
    --project $PREFIX/ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI/ \
    &
dotnet watch build \
    --project $PREFIX/ProjectsStructureTemplate.Servers.MicroService.gRPC/ \
    &
dotnet watch build \
    --project $PREFIX/ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted/ \
    &
dotnet watch build \
    --project $PREFIX/ProjectsStructureTemplate.Servers.MicroService.Worker.BackgroundService/ \
    &

```

## Description

*   ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI

    *   REST WebAPI ASP.net WebAPI project

        ```bash
        dotnet new webapi -o ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI
        ```

*   ProjectsStructureTemplate.Servers.MicroService.gRPC

    *   gRPC ASP.net Core project

        ```bash
        dotnet new grpc -o ProjectsStructureTemplate.Servers.MicroService.gRPC
        ```

*   ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted

    *  SignalR ASP.net Core project

        ```bash
        dotnet new console -o ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted
        ```
    *   add package

        ```bash
        dotnet add \
            ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted \
                package \
                    Microsoft.AspNet.SignalR.SelfHost
        dotnet add \
            ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted \
                package \
                    Microsoft.AspNet.SignalR.Core
        dotnet add \
            ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted \
                package \
                    System.Diagnostic  
        ```

*   ProjectsStructureTemplate.Servers.MicroServices.DemoSamples.sln

    *   solution file

        ```bash
        dotnet new sln -o ProjectsStructureTemplate.Servers.MicroServices.DemoSamples.sln
        dotnet sln add \
            ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI/ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI.csproj
        dotnet sln add \
            ProjectsStructureTemplate.Servers.MicroService.gRPC/ProjectsStructureTemplate.Servers.MicroService.gRPC.csproj
        dotnet sln add \
            ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted/ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted.csproj
        ```
