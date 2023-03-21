using SistemaEspecialista.Domain.Entities;
using System.Linq.Expressions;

namespace SistemaEspecialista.Application.Interfaces.Repositories;

public interface IObjectiveRepository
{
    /// <summary>
    /// Get all objectives in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of Objective</returns>
    public Task<IEnumerable<Objective>> GetAll(CancellationToken cancellationToken);

    /// <summary>
    /// Get all objective by a where in the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A Task of type IEnumerable of Objective</returns>
    public Task<IEnumerable<Objective>> Search(Expression<Func<Objective, bool>> predicate, CancellationToken cancellationToken);

    /// <summary>
    /// Get all objective by projectId in the database.
    /// </summary>
    /// <param name="projectId"></param>
    /// <returns>A Task of type IEnumerable of Objective</returns>
    Task<List<Objective>> GetObjectivesByProjectAsync(int projectId);

    /// <summary>
    /// Get a objective by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Objective> GetById(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Add a objective to the database.
    /// </summary>
    /// <param name="objective"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Objective> Add(Objective objective, CancellationToken cancellationToken);

    /// <summary>
    /// Update a objective to the database by the primary key
    /// </summary>
    /// <param name="objective"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Objective> Update(Objective objective);

    /// <summary>
    /// Removes a objective to the database by the primary key
    /// </summary>
    /// <param name="objective"></param>
    /// <returns>A task of type Objective</returns>
    public Task<Objective> Remove(Objective objective);
}

