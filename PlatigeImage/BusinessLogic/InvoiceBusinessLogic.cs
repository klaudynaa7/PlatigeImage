using Microsoft.EntityFrameworkCore;
using PlatigeImage.Data;
using PlatigeImage.Data.Entities;
using PlatigeImage.Infrastructure.Connection;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace PlatigeImage.BusinessLogic
{
    public static class InvoiceBusinessLogic
    {
        static ConnectionDetails _connectionInfo = ConnectionDetails.GetInstance();

        public static List<Invoice>? GenerateIvoices(int value)
        {
            if (value <= 0)
                return null;
            else
            {
                using (var context = new ApplicationDbContext(_connectionInfo.GetConnectionString()))
                {
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceName = "PlatigeImage.Resources.random_invoice_data.json";

                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        var jsonData = reader.ReadToEnd();
                        var invoicesFromJson = JsonSerializer.Deserialize<List<Invoice>>(jsonData);
                        var contractorIds = context.Contractors.AsNoTracking().Select(c => c.Id).ToList();

                        var invoicesToAdd = invoicesFromJson?.Take(value).Select(invoice =>
                        {
                            invoice.ContractorId = contractorIds[new Random().Next(contractorIds.Count)];
                            return invoice;
                        }).ToList();

                        return invoicesToAdd;
                    }
                }
            }
        }
    }
}
