#!bin/bash

export DIR_PREFIX="architecture/server/microservices/ProjectsStructureTemplate.Servers.MicroService"
export DIR_PREFIX="./ProjectsStructureTemplate.Servers.MicroService"

# https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-watch

dotnet watch \
    run \
        --project $DIR_PREFIX.REST.WebAPI/ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.REST.API/ProjectsStructureTemplate.Servers.MicroService.REST.API.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.SignalR.SelfHosted/ProjectsStructureTemplate.Servers.MicroService.SignalR.SelfHosted.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.gRPC/ProjectsStructureTemplate.Servers.MicroService.gRPC.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.SOAP/ProjectsStructureTemplate.Servers.MicroService.SOAP.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.MQTT/ProjectsStructureTemplate.Servers.MicroService.MQTT.csproj \

dotnet watch \
    run \
        --project $DIR_PREFIX.WorkerBackgroundService/ProjectsStructureTemplate.Servers.MicroService.WorkerBackgroundService.csproj \



tye run ProjectsStructureTemplate.Servers.MicroService.Web 
tye run ProjectsStructureTemplate.Servers.MicroService.REST.WebAPI
tye run ProjectsStructureTemplate.Servers.MicroService.REST.API

open http://localhost:8000