using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Plants.Schemas;

namespace IntegrationTests
{
    // controller ----> model + schema ----> dataservice
    public class IntegrationTests
    {
        // server - props/fields
        private readonly WebApplicationFactory<Program> _webApplicationFactory;

        // client - props/fields
        private readonly HttpClient _httpClient;

        // construtor to populate the fields 
        public IntegrationTests()
        {
            _webApplicationFactory = new WebApplicationFactory<Program>();
            // re above, this will use the singletons of the Model, which is what we want, but also of the DataAccess layer, which we don't, i am looking into this this afternoon and will update 
            
            _httpClient = _webApplicationFactory.CreateClient();
        }

        [Fact]
        public async Task GET_StatusCode200_CollectionOfPlants()
        {

            var response = await _httpClient.GetAsync("api/plants");

            var stringResult = await response.Content.ReadAsStringAsync();

            List<Plant> content = JsonConvert.DeserializeObject<List<Plant>>(stringResult);

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal("Tiffany", content[0].Name);
        }
    }
}