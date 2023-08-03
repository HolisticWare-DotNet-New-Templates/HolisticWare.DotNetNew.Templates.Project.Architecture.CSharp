using ProjectsStructureTemplate.Servers.MicroService.WorkerBackgroundService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
