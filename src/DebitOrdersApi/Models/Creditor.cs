using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Models
{
    public class Creditor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string  Name { get; set; }
        public int BankCode { get; set; }
        public int BranchCode { get; set; }
        public string AccountNumber { get; set; }
    }
}
