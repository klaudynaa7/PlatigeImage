using PlatigeImage.Data.Entities;

namespace PlatigeImage.BusinessLogic
{
    public static class ContractorBusinessLogic
    {
        private static string[] languages = { "PL", "ENG", "DE", "FE", "CZ", "ES", "IT" };

        public static List<Contractor>? GenerateContractors(int value)
        {
            if (value <= 0)
                return null;
            else
            {
                var random = new Random();
                var contractors = new List<Contractor>();

                for (int i = 0; i < value; i++)
                {
                    var kontrahent = new Contractor
                    {
                        Type = (byte)random.Next(0, 1),
                        Name = $"Kontrahent {i + 1}",
                        Shortcut = $"K  {i + 1}",
                        Country = languages[random.Next(languages.Length)],
                        Address = $"Ulica {random.Next(1, 100)}, Miasto {random.Next(1, 50)}",
                        NIP = $"{random.Next(100000000, 999999999)}",
                        IsActive = random.Next(0, 2) > 1
                    };

                    contractors.Add(kontrahent);
                }
                return contractors;
            }
        }
    }
}
