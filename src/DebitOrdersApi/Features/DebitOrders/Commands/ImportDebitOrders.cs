using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.DebitOrders.Commands
{
    public class ImportDebitOrders : IRequest
    {
        public string AccountName { get; set; }
        public string IdNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BankCode { get; set; }
        public decimal DebitAmount { get; set; }
        public string DebitNarration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
