using CorePlatform.RuleEvaluation;
using CorePlatform.Services.Infrastructure.Data;
using CorePlatform.Services.Infrastructure.Repository;
using CorePlatform.Services.UseCases.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePlatform.Services.UseCases.CommandQueries.MemberRule.Query
{
    public class MemberRuleQueryHandler : IRequestHandler<MemberRuleQuery, ResultInfo<IEnumerable<MemberRuleEvaluationDTO>>>
    {
        public MemberRuleQueryHandler(AppDbContext context)
        {
            UnitOfWork.Initialize(context);
        }

        public async Task<ResultInfo<IEnumerable<MemberRuleEvaluationDTO>>> Handle(MemberRuleQuery request, CancellationToken cancellationToken)
        {

            var library =  UnitOfWork.RuleLibraryRepository.GetByID(3);

            var result = new List<MemberRuleEvaluationDTO>();

            return Result.Result.Success(result.AsEnumerable());
        }
    }
}
