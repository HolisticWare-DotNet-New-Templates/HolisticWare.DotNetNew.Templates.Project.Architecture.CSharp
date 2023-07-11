# Servers

readme.md


```
ASP.NET Core Empty                                                 web                                   [C#],F#     Web/Empty                                                                        
ASP.NET Core gRPC Service                                          grpc                                  [C#]        Web/gRPC                                                                         
ASP.NET Core Web API                                               webapi                                [C#],F#     Web/WebAPI                                                                       
ASP.NET Core Web App                                               webapp,razor                          [C#]        Web/MVC/Razor Pages                                                              
ASP.NET Core Web App (Model-View-Controller)                       mvc                                   [C#],F#     Web/MVC                                                                          
ASP.NET Core with Angular                                          angular                               [C#]        Web/MVC/SPA                                                                      
ASP.NET Core with React.js                                         react                                 [C#]        Web/MVC/SPA                                                                      
ASP.NET Core with React.js and Redux                               reactredux                            [C#]        Web/MVC/SPA                                                                      
```

## REST - WebAPI

```
dotnet new \
	webapi \
		--output \
			ProjectsStructureTemplate.Servers.REST.WebAPI

dotnet add \
	ProjectsStructureTemplate.Servers.REST.WebAPI \
		package \
			Microsoft.NET.Build.Containers

```

## gRPC

```
dotnet new \
	grpc \
		--output \
			ProjectsStructureTemplate.Servers.gRPC
```

*	https://github.com/davidfowl/TodoApi

## SignalR Self Hosted

*	https://www.milanjovanovic.tech/blog/adding-real-time-functionality-to-dotnet-applications-with-signalr

*	https://learn.microsoft.com/en-us/aspnet/signalr/overview/deployment/tutorial-signalr-self-host

*	https://stackoverflow.com/questions/68085210/how-to-have-a-self-hosting-signalr-server-running-as-as-netcore-console-app

https://stackoverflow.com/questions/19396298/using-signalr-as-a-standalone-server-application-and-not-an-asp-net-one

https://stackoverflow.com/questions/60422432/host-a-signalr-hub-in-a-net-core-3-1-console

https://github.com/xtrmstep/SignalRServerClient

Self Hosting SignalR and Web API (Self Host Server, C#) | Visual Studio 2019 | Part 1
    https://www.youtube.com/watch?v=HhRoZ7zR_9M&ab_channel=Hacked

*	Self Hosting SignalR and Web API (Self Host Server, C#) | Visual Studio 2019 | Part 3
    
	*	https://www.youtube.com/watch?v=f-COVqUL8NI&ab_channel=Hacked

https://www.c-sharpcorner.com/UploadFile/4b0136/introduction-of-Asp-Net-signalr-self-hosting/

*	Self Hosting SignalR and Web API (Self Host Server, C#) | Visual Studio 2019 | Part 3# SignalR

	*   https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-7.0&tabs=visual-studio

*	https://github.com/dotnet/aspnetcore/blob/main/src/SignalR/docs/specs/HubProtocol.md?WT.mc_id=dotnet-35129-website

*	https://github.com/dotnet/aspnetcore/tree/main/src/SignalR?WT.mc_id=dotnet-35129-website

*	https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?WT.mc_id=dotnet-35129-website&view=aspnetcore-7.0

*	https://www.c-sharpcorner.com/article/how-to-receive-real-time-data-in-net-6-client-application-using-signalr/

*	https://www.telerik.com/blogs/bring-your-apps-life-signalr-dotnet-6

*	https://www.bacancytechnology.com/blog/signalr-in-net-core

*	SignalR in ASP.NET Core Projects (1/3)- Full Course from Wilder Minds

    *	https://www.youtube.com/watch?v=hGxr1yAb1gk&ab_channel=ShawnWildermuth

*	SignalR in ASP.NET Core Projects (2/3): Angular - Full Course from Wilder Minds

    *	https://www.youtube.com/watch?v=YEFVpqmjx78&t=0s&ab_channel=ShawnWildermuth

*	SignalR in ASP.NET Core Projects (3/3): Vue.js - Full Course from Wilder Minds

    *	https://www.youtube.com/watch?v=golo0kXY-w0&t=0s&ab_channel=ShawnWildermuth

*	https://www.c-sharpcorner.com/article/stream-web-api-transactions-using-signalr/

*	https://riptutorial.com/signalr/example/22571/using-signalr-with-web-api-and-javascript-web-app--with-cors-support-

*	https://medium.com/@jaydeepvpatil225/signalr-introduction-and-implementation-using-the-net-core-6-web-api-and-angular-14-b4cfd51a6fac

*	https://stackoverflow.com/questions/12368800/can-i-incorporate-both-signalr-and-a-restful-api

*	https://bradwilson.typepad.com/blog/2012/07/webstack-of-love.html

*	https://vimeo.com/43603472

*	https://github.com/bradwilson/WebstackOfLove/

## Diverse

