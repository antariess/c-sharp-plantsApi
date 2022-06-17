using Plants.Schemas;

namespace Plants.Models
{
    public interface IPlants
    {
        public List<Plant> FetchAllPlants();
    }
}
