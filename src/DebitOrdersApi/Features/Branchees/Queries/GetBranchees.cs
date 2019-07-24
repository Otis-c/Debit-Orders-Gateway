using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.Branchees.Queries
{
    public class GetBranchees: IRequest<IEnumerable<Branch>>
    {
    }
    public class GetBrancheesHandler : IRequestHandler<GetBranchees, IEnumerable<Branch>>
    {
        private readonly DataContext _db;

        public GetBrancheesHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Branch>> Handle(GetBranchees request, CancellationToken cancellationToken)
        {
            var branches = await _db.Branches.ToListAsync();
            return branches;
        }
    }
}
