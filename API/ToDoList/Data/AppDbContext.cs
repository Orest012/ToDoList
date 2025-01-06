using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using ToDoList.Models;

namespace ToDoList.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<User> Users { get; set; }


}
