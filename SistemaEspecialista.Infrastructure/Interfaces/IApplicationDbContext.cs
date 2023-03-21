using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Infrastructure.Interfaces;

public interface IApplicationDbContext
{
    /// <summary>
    /// Projects DbSet (Projects Table).
    /// </summary>
    public DbSet<Project> Projects { get; set; }

    /// <summary>
    /// Objectives DbSet (Objectives Table).
    /// </summary>
    public DbSet<Objective> Objectives { get; set; }

    /// <summary>
    /// Characteristics DbSet (Characteristics Table).
    /// </summary>
    public DbSet<Characteristic> Characteristics { get; set; }

    /// <summary>
    /// ObjectiveCharacteristics DbSet (ObjectiveCharacteristics Table).
    /// </summary>
   
    public DbSet<ObjectiveCharacteristic> ObjectiveCharacteristics { get; set; }
    /// <summary>
    /// Questions DbSet (Questions Table).
    /// </summary>
    
    public DbSet<Question> Questions { get; set; }
    
    /// <summary>
    /// Alter the CreatedAt or Updated of the Entities depending on the action and commit the changes to the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());

    /// <summary>
    /// Gets the TEntity DbSet.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <returns>DbSet of type TEntity </returns>
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;

    /// <summary>
    /// Gets the DatabaseFacade.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <returns>DatabaseFacade</returns>
    public DatabaseFacade? Database { get; }
}
