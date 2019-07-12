using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.DebitOrders.Commands
{
    public class SaveDebitOrder : IRequest
    {
        public string AccountName { get; set; }
        public string IDNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BankCode { get; set; }
        public decimal DebitAmount { get; set; }
        public string DebitNarration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Creditor { get; set; }
    }

    public class SaveOrderHandler : IRequestHandler<SaveDebitOrder>
    {
        private readonly DataContext _db;

        public SaveOrderHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<Unit> Handle(SaveDebitOrder request, CancellationToken cancellationToken)
        {
            var instruction = new DebitInstruction
            {
                AccountName = request.AccountName,
                IDNumber = request.IDNumber,
                AccountNumber = request.AccountNumber,
                BranchCode = request.BranchCode,
                BankCode = request.BankCode,
                DebitNarration = request.DebitNarration,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Creditor = request.Creditor
            };

            _db.DebitInstructions.Add(instruction);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            

            return Unit.Value;


        }
    }
}
