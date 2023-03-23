using Microsoft.EntityFrameworkCore;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;
using System.Linq.Expressions;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class ObjectiveCharacteristicRepository : Repository<ObjectiveCharacteristic>, IObjectiveCharacteristicRepository
{
    public ObjectiveCharacteristicRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<ObjectiveCharacteristic>> GetObjectiveCharacteristicByProjectAsync(int projectId)
    {
        return (await base.Search(objectiveCharacteristic => objectiveCharacteristic.ProjectId == projectId,
            CancellationToken.None)).ToList();
    }

    public async Task<List<ObjectiveCharacteristic>> GetWithCharacteristics(Expression<Func<ObjectiveCharacteristic, bool>> predicate)
    {
        return (await EntityDbSet
            .AsNoTracking()
            .Where(predicate)
            .Include(w => w.Characteristic)
            .ToListAsync());
    }
}
