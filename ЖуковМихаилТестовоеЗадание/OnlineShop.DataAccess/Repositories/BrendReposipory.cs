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
    public class BrendReposipory : IBrendsReposipory
    {
        private DataContext _context;

        public BrendReposipory(DbContext context)
        {
            _context = (DataContext)context;
        }

        public int AddBrand(TblBrend brend)
        {
            _context.TblBrends.Add(brend);
            return _context.SaveChanges();
        }

        public int DeleteBrend(TblBrend brend)
        {
            if (GetBrend(brend.Id) != null)
            {
                _context.TblBrends.Remove(brend);
                return _context.SaveChanges();
            }
            return 0;
        }

        public TblBrend GetBrend(int Id)
        {
            return _context.TblBrends.FirstOrDefault(x=>x.Id == Id);
        }

        public IEnumerable<TblBrend> GetBrends()
        {
            return _context.TblBrends;
        }

        public int UpdateBrend(TblBrend brend)
        {
            TblBrend t = GetBrend(brend.Id);
            t.Brend = brend.Brend;
            return _context.SaveChanges();
        }
    }
}
