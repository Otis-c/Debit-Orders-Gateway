using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.Banks.Commands
{
    public class AddBank : IRequest<Bank>
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class AddBankHandler : IRequestHandler<AddBank, Bank>
    {
        private readonly DataContext _db;

        public AddBankHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<Bank> Handle(AddBank request, CancellationToken cancellationToken)
        {
            var bank = new Bank
            {
                Code = request.Code,
                Name = request.Name
            };

            _db.Add(bank);
           await _db.SaveChangesAsync();

            return bank;
        }
    }

}