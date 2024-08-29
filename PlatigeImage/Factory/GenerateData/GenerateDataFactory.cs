using PlatigeImage.Data.Entities;
using PlatigeImage.GenerateData;
using PlatigeImage.Infrastructure.DataAccess.Contractors;

namespace PlatigeImage.Factory.GenerateData
{
    public class GenerateDataFactory(IServiceProvider serviceProvider, IContractorRepository contractorRepository) : IGenerateDataFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;
        private readonly IContractorRepository _contractorRepository = contractorRepository;

        public IGenerateData<T> Create<T>() where T : BaseEntity
        {
            return typeof(T).Name switch
            {
                nameof(Contractor) => (IGenerateData<T>)new GenerateContractors(),
                nameof(Invoice) => (IGenerateData<T>)new GenerateInvoices(_contractorRepository),
                _ => throw new ArgumentException()
            };
        }
    }
}
