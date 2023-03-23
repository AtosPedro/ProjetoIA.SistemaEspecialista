using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<Characteristic> Characteristics { get; set; }
    public DbSet<ObjectiveCharacteristic> ObjectiveCharacteristics { get; set; }
    public DbSet<Question> Questions { get; set; }
    public override DatabaseFacade? Database => base.Database;

    public override EntityEntry Entry(object entity)
    {
        return base.Entry(entity);
    }

    public void DetachLocal<T>(IApplicationDbContext context, T t, int entryId) where T : Entity
    {
        var local = context.Set<T>()
            .Local
            .FirstOrDefault(entry => entry.Id.Equals(entryId));
        if (local is not null)
            context.Entry(local).State = EntityState.Detached;

        context.Entry(t).State = EntityState.Modified;
    }

    public ApplicationDbContext()
    {
        if (Database.GetPendingMigrations().Any())
            Database.Migrate();
    }

    /// <summary>
    /// Gets the TEntity DbSet.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <returns>DbSet of type TEntity </returns>
    public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity => base.Set<TEntity>();

    /// <summary>
    /// Alter the CreatedAt or Updated of the Entities depending on the action and commit the changes to the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(DbConfig.ConnectionString);
    }
}
