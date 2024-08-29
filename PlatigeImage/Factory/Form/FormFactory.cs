using Microsoft.Extensions.DependencyInjection;

namespace PlatigeImage.Factory.FormFactory
{
    public class FormFactory(IServiceProvider serviceProvider) : IFormFactory
    {
        private readonly IServiceProvider _serviceProvider = serviceProvider;

        public T Create<T>() where T : Form
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
