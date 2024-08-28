using DevExpress.XtraEditors.Controls;
using PlatigeImage.Data;
using PlatigeImage.Enums;
using PlatigeImage.Infrastructure.Connection;

namespace PlatigeImage.BusinessLogic
{
    public static  class CommonBusinessLogic
    {
        private const string _comapany = "Firma";
        private const string _individual = "Osoba prywatna";
        static ConnectionDetails _connectionInfo = ConnectionDetails.GetInstance();

        public static void FillType(ImageComboBoxItemCollection items)
        {
            items.Clear();
            items.Add(new ImageComboBoxItem(_comapany, Convert.ToByte(ContractorType.Company), -1));
            items.Add(new ImageComboBoxItem(_individual, Convert.ToByte(ContractorType.Individual), -1));
        }

        public static void FillContractor(ImageComboBoxItemCollection items)
        {
            items.Clear();

            using (var dbContext = new ApplicationDbContext(_connectionInfo.GetConnectionString()))
            {
                foreach (var contractor in dbContext.Contractors.ToList())
                {
                    items.Add(new ImageComboBoxItem(contractor.Name, contractor.Id, -1));
                }
            }
        }
    }
}
