using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.Branchees.Commands
{
    public class AddBranchees: IRequest<Branch>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int BankId { get; set; }
        //public string Bank { get; set; }

    }
    public class AddBrancheesHandler : IRequestHandler<AddBranchees, Branch>
    {
        private readonly DataContext _db;

        public AddBrancheesHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<Branch> Handle(AddBranchees request, CancellationToken cancellationToken)
        {
            var branch = new Branch
            {
                Code = request.Code,
                Name = request.Name,
                BankId = request.BankId,
                //Bank = request.Bank;
            };

            _db.Add(branch);
            await _db.SaveChangesAsync();

            return branch;
        }
    }
}
