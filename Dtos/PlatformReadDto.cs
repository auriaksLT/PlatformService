// Any Data/Context that will be provided by us to third party
namespace PlatformService.Dtos
{
    public class PlatformReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Publisher { get; set; }
        
        public string Cost { get; set; }
    }
}