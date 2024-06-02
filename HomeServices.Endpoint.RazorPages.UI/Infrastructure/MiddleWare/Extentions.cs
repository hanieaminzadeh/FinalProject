﻿namespace HomeServices.Endpoint.RazorPages.UI.Infrastructure.MiddleWare;

public static class MiddlewareExtensions
{
    public static IApplicationBuilder CustomExceptionHandlingMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandlingMiddleware>();
    }

    //public static IApplicationBuilder DetectVpnMiddleware(this IApplicationBuilder builder)
    //{
    //    return builder.UseMiddleware<DetectVpnMiddleware>();
    //}
}
