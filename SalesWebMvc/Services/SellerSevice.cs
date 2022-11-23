using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class SellerSevice
    {
        private readonly SalesWebMvcContext _context;

        public SellerSevice(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Remove(int id)
        {
            var x = _context.Seller.Find(id);
            _context.Seller.Remove(x);
            _context.SaveChanges();
        }
    }
}
