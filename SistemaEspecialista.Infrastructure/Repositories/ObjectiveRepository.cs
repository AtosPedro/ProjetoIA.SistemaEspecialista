using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class ObjectiveRepository : Repository<Objective>, IObjectiveRepository
{
    public ObjectiveRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Objective>> GetObjectivesByProjectAsync(int projectId)
    {
        return (await base.Search( objective => objective.ProjectId == projectId,
            CancellationToken.None)).ToList();
    }
}
