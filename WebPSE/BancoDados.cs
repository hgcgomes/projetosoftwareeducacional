using System.Data.Entity;

namespace WebPSE
{
    public class BancoDados : DbContext
    {
        public BancoDados()
            : base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<WebPSE.Models.Pessoa> Pessoas { get; set; }
    }
}