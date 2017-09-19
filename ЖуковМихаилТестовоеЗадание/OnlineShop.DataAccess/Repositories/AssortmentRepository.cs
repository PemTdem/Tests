using OnlineShop.DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities;
using System.Data.Entity;

namespace OnlineShop.DataAccess.Repositories
{
    public class AssortmentRepository : IAssortmentRepository
    {
        private DataContext _context;

        public AssortmentRepository(DbContext context)
        {
            _context = (DataContext)context;
        }

        public int AddAssortment(TblAssortment assortment)
        {
            _context.TblAssortments.Add(assortment);
            return _context.SaveChanges();
        }

        public int DeleteAssortment(TblAssortment assortment)
        {
            if(GetAssortment(assortment.Id) != null)
            {
                _context.TblAssortments.Remove(assortment);
                return _context.SaveChanges();
            }
            return 0;
        }

        public TblAssortment GetAssortment(Guid Id)
        {
            return _context.TblAssortments.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<TblAssortment> GetAssortments()
        {
            return _context.TblAssortments;
        }

        public int UpdateAssortment(TblAssortment assortment)
        {
            TblAssortment t = GetAssortment(assortment.Id);
            t.Name = assortment.Name;
            t.IdBrand = assortment.IdBrand;
            t.Article = assortment.Article;
            return _context.SaveChanges();
        }
    }
}
