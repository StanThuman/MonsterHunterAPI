
using System.Data.Entity;

namespace MonsterHunterAPI.Dal.Models
{
    public class MonsterHunterContext : DbContext
    {
        public MonsterHunterContext(): base("MonsterHunterContext"){}

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<EquipmentElement> EquipmentElement { get; set; }
        public DbSet<Element> Elements { get; set; }

        private void AddAdoServiceProblem() {
            var instace = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

    }
}
