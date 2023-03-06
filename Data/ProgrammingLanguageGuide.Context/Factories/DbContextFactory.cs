﻿namespace ProgrammingLanguageGuide.Context.Factories;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbContextFactory
{
    private readonly DbContextOptions<MainDbContext> options;
    public DbContextFactory(DbContextOptions<MainDbContext> options)
    {
        this.options = options;
    }

    public MainDbContext Create()
    {
        return new MainDbContext(options);
    }
}
