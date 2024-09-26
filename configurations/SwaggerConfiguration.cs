using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;


namespace APIVersionDemo.Configurations;

public class SwaggerConfiguration : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    public SwaggerConfiguration(IApiVersionDescriptionProvider provider) => _provider = provider;

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
        }
    }

    private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = "API Versioning Demo Web API",
                Version = description.ApiVersion.ToString(),
                Description = @"This project demonstrates how to implement API versioning in a .NET Core Web API. API versioning is essential for managing changes in APIs over time without breaking existing clients. In this project, we explore three common ways to specify API versions:
                                 **Via ( URL** 
                                - **HTTP Header**
                                - **Content-Type** )",
                Contact = new OpenApiContact()
                {
                    Name = "Eslam Shaban",
                    Email = "Eslamshaban69815@gmail.com",
                    Url = new Uri("https://github.com/Eslamshaban176"),

                },
            };

            if (description.IsDeprecated)
            {
                info.Description += " This API version has been deprecated.";
            }

            return info;
        }

}
