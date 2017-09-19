using OnlineShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Services.Data;
using OnlineShop.DataAccess.Repositories.Base;
using OnlineShop.Domain.Entities;
using OnlineShop.Services.Implementation.Dase;
using OnlineShop.DataAccess.Repositories;

namespace OnlineShop.Services.Implementation
{
    public class BrendServices : BaseService, IBrendServices
    {
        IBrendsReposipory _brendsReposipory;

        public BrendServices()
        {
            _brendsReposipory = new BrendReposipory(context);
        }


        public int AddBrand(Brend brend)
        {
            TblBrend tb = new TblBrend();
            tb.Id = brend.Id;
            tb.Brend = brend.BrendName;

           return _brendsReposipory.AddBrand(tb);
        }

        public int AddBrends(IEnumerable<Brend> listBrends)
        {
            int i = 0;
            foreach (Brend item in listBrends)
            {
                i += AddBrand(item);
            }
            return i;
        }

        public int DeleteBrend(Brend brend)
        {
            TblBrend tb = new TblBrend();
            tb.Id = brend.Id;
            tb.Brend = brend.BrendName;
            return _brendsReposipory.DeleteBrend(tb);
        }

        public int DeleteBrends(IEnumerable<Brend> listBrends)
        {
            int i = 0;
            foreach (Brend item in listBrends)
            {
                i += DeleteBrend(item);
            }
            return i;
        }

        public Brend GetBrend(int Id)
        {
            var brend =_brendsReposipory.GetBrend(Id);
            Brend b = new Brend();
            b.Id = brend.Id;
            b.BrendName = brend.Brend;
            return b;
        }

        public IEnumerable<Brend> GetBrends()
        {
            return _brendsReposipory.GetBrends().Select(x => new Brend {
                Id = x.Id,
                BrendName = x.Brend
            });
        }

        public int UpdateBrend(Brend brend)
        {
            TblBrend tb = new TblBrend();
            tb.Id = brend.Id;
            tb.Brend = brend.BrendName;
            return _brendsReposipory.UpdateBrend(tb);
        }

        public int UpdateBrends(IEnumerable<Brend> listBrends)
        {
            int i = 0;
            foreach (Brend item in listBrends)
            {
                i += UpdateBrend(item);
            }
            return i;
        }
    }
}
