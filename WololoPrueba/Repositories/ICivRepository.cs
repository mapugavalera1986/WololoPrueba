using WololoPrueba.Models;

namespace WololoPrueba.Repositories
{
    public interface ICivRepository
    {
        public Task<IEnumerable<Civ>> GetCivs();
        public Task<Civ> GetCivById(int civId);
    }
}
