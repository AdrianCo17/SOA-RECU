using Domain;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class AssetRepository
    {
        private readonly ApplicationDBContext _context;

        public AssetRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Activo> GetAssets()
        {
            return _context.Activos.ToList();
        }

        public int Create(Activo activo)
        {
            _context.Activos.Add(activo);
            return _context.SaveChanges();
        }
    }
}
