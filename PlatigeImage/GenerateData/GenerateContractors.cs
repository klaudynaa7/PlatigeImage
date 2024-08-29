using PlatigeImage.Data.Entities;

namespace PlatigeImage.GenerateData
{
    public class GenerateContractors : IGenerateData<Contractor>
    {
        private readonly string[] languages = { "PL", "ENG", "DE", "FE", "CZ", "ES", "IT" };

        public async Task<List<Contractor>?> GenerateData(int inputValue)
        {
            List<Contractor>? contractors = [];
            var random = new Random();
            for (int i = 0; i < inputValue; i++)
            {
                var kontrahent = new Contractor
                {
                    Type = Convert.ToByte(random.Next(0, 2)),
                    Name = $"Kontrahent {i + 1}",
                    Shortcut = $"K  {i + 1}",
                    Country = languages[random.Next(languages.Length)],
                    Address = $"Ulica {random.Next(1, 100)}, Miasto {random.Next(1, 50)}",
                    NIP = $"{random.Next(100000000, 999999999)}",
                    IsActive = Convert.ToBoolean(random.Next(0, 2))
                };

                contractors.Add(kontrahent);
            }
            return contractors;
        }

    }
}
