var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Unity_WebApi>("unity-webapi");

builder.AddProject<Projects.Unity_BlazorApp>("unity-blazorapp");

builder.Build().Run();
