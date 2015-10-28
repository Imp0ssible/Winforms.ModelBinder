using System.Collections.Generic;

namespace Winforms.ModelBinder
{
    public class EngineType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public static IEnumerable<EngineType> GetEngineTypes()
        {
            yield return new EngineType { Id = 1, Name = "D-4D", Manufacturer = "Toyota" };
            yield return new EngineType { Id = 2, Name = "VVT-I", Manufacturer = "Toyota" };
            yield return new EngineType { Id = 3, Name = "K9K", Manufacturer = "Renault" };
            yield return new EngineType { Id = 4, Name = "J8S", Manufacturer = "Renault" };
        }
    }
}
