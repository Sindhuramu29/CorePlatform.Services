using CorePlatform.Services.Core.Rule;
using System.Data;

namespace CorePlatform.Services.Infrastructure.Repository
{
    public interface IUnitOfWork
    {
        public GenericRepository<RulesLibrary> RuleLibraryRepository { get; }
        public GenericRepository<PlanAssociation> PlanRepository { get; }
        Task<int> Save();
    }
}