using DevExpress.Diagram.Core.Native;
using PlatigeImage.Data.Entities;
using PlatigeImage.Infrastructure.DataAccess.Contractors;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace PlatigeImage.GenerateData
{
    public class GenerateInvoices(IContractorRepository contractorRepository) : IGenerateData<Invoice>
    {
        private readonly IContractorRepository _contractorRepository = contractorRepository;
        private const string filePath = "PlatigeImage.Resources.random_invoice_data.json";

        public async Task<List<Invoice>?> GenerateData(int inputValue)
        {

            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(filePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                List<Invoice>? invoices = [];
                var jsonData = reader.ReadToEnd();
                var invoicesFromJson = JsonSerializer.Deserialize<List<Invoice>>(jsonData);
                var contractorIds = await _contractorRepository.GetIdsAsync();

                invoices = invoicesFromJson?.Take(inputValue).Select(invoice =>
                {
                    invoice.ContractorId = contractorIds[new Random().Next(contractorIds.Count)];
                    return invoice;
                }).ToList();

                return invoices;
            }


        }
    }
}
