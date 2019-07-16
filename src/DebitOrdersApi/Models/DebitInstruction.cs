using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Models
{
    public class DebitInstruction
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string IDNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BankCode { get; set; }
        public decimal DebitAmount { get; set; }
        public string DebitNarration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProcessingDay { get; set; }
        public string Creditor { get; set; }
    }
}
