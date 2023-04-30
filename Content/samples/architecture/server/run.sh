#!bin/bash


dotnet watch \
    run \
        --project ./ProjectsStructureTemplate.Servers.REST.WebAPI/ProjectsStructureTemplate.Servers.REST.WebAPI.csproj

dotnet watch \
    run \
        --project ./ProjectsStructureTemplate.Servers.gRPC/ProjectsStructureTemplate.Servers.gRPC.csproj