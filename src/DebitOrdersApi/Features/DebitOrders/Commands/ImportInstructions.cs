using DebitOrdersApi.Data;
using DebitOrdersApi.Models;
using MediatR;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DebitOrdersApi.Features.DebitOrders.Commands
{
    public class ImportInstructions : IRequest
    {
        public string FileName;
        public byte[] FileBytes { get; set; }
        
    }

    public class ImportInstructionsHandler : IRequestHandler<ImportInstructions>
    {
        private readonly DataContext _db;

        public ImportInstructionsHandler(DataContext db)
        {
            _db = db;
        }
        public async Task<Unit> Handle(ImportInstructions request, CancellationToken cancellationToken)
        {
            try
            {
                using (var stream = new MemoryStream(request.FileBytes))
                {

                    using (var package = new ExcelPackage(stream))
                    {
                        var workSheet = package.Workbook.Worksheets[0];
                        var rowCount = workSheet.Dimension.Rows;
                        var columnCount = workSheet.Dimension.Columns;

                        var transactions = new List<DebitInstruction>();

                        for (int i = 2; i < rowCount; i++)
                        {
                            var accountName = workSheet.Cells[i, 1].Value.ToString();
                            var idNumber = workSheet.Cells[i, 2].Value.ToString();
                            var accountNumber = workSheet.Cells[i, 3].Value.ToString();
                            var branchCode = workSheet.Cells[i, 4].Value.ToString();
                            var bankCode = workSheet.Cells[i, 5].Value.ToString();
                            var debitAmount = workSheet.Cells[i, 6].Value.ToString();
                            var narration = workSheet.Cells[i, 7].Value.ToString();
                            var startDate = workSheet.Cells[i, 8].Value.ToString();
                            var endDate = workSheet.Cells[i, 9].Value.ToString();
                            var creditor = workSheet.Cells[i, 10].Value.ToString();
                            decimal amt = 0;
                            if (!string.IsNullOrEmpty(debitAmount) || !string.IsNullOrWhiteSpace(debitAmount))
                            {                                
                                decimal.TryParse(debitAmount, out amt);                               
                            }

                            _db.DebitInstructions.Add(new DebitInstruction
                            {
                                AccountName = accountName,
                                AccountNumber = accountNumber,
                                IDNumber = idNumber,
                                BankCode = bankCode,
                                BranchCode = branchCode,
                                DebitAmount = amt,
                                StartDate = DateTime.Now,
                                EndDate = DateTime.Now,
                                Creditor = creditor

                            });
                        }                        
                        await _db.SaveChangesAsync();
                    }
                }
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
