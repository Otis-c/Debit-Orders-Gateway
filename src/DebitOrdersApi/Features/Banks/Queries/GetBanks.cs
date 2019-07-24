using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.Banks.Queries
{
    public class GetBanks :IRequest<IEnumerable<Bank>>
    {
       
    }
    public class GetBanksHandler : IRequestHandler<GetBanks, IEnumerable<Bank>>
    {
        private readonly DataContext _db;

        public GetBanksHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Bank>> Handle(GetBanks request, CancellationToken cancellationToken)
        {
            var banks = await _db.Banks.ToListAsync();
            return banks;
        }
    }
}
