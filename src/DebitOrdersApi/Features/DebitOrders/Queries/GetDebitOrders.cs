using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.DebitOrders.Queries
{
    public class GetDebitOrders : IRequest<IEnumerable<DebitInstruction>>
    {
        
    }

    public class GetDebitOrdersHander : IRequestHandler<GetDebitOrders, IEnumerable<DebitInstruction>>
    {
        private readonly DataContext _db;

        public GetDebitOrdersHander(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<DebitInstruction>> Handle(GetDebitOrders request, CancellationToken cancellationToken)
        {
            var debitInstructions = _db.DebitInstructions.ToList();
            return debitInstructions;
        }
    }
}
