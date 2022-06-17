using Plants.Schemas;
using DataAccessLayer;

namespace Plants.Models
{
    public class Plants : IPlants
    {
        private IDataService _dataService;

        public Plants(IDataService dataService)
        {
            _dataService = dataService;
        }

        //public Plant FetchSinglePlant(Guid id)
        //{
        //    // invoke data access layer, find plant with the right id, and return it
        //}

        public List<Plant> FetchAllPlants()
        {
            // invoke data access layer, grab hold of all plants and return them
            var data = _dataService.GetData<Plant>().ToList();
            // pretend the below is not here
            data.Add(new Plant("Tiffany", true, Guid.NewGuid()));
            data.Add(new Plant("Barnaby", true, Guid.NewGuid()));
            // pretend the above is not here


            // null check, and other potential checks - can pass onto error handling service

            return data;
        }
    }
}
