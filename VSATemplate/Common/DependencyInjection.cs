﻿using Microsoft.EntityFrameworkCore.Diagnostics;

namespace VerticalSliceArchitectureTemplate.Common;

public static class DependencyInjection
{
    public static void AddEfCore(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>((sp, options) =>
        {
            options.UseInMemoryDatabase("InMemoryDbForTesting");
        });
    }
}