using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Question>> GetObQuestionByProjectAsync(int projectId)
        {
            return (await base.Search(q => q.ProjectId == projectId, CancellationToken.None)).ToList();
        }
    }
}
