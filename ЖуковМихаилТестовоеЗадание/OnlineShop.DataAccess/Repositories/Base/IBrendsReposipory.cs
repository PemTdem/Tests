using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities;

namespace OnlineShop.DataAccess.Repositories.Base
{
    public interface IBrendsReposipory
    {
        int AddBrand(TblBrend brend);
        
        int UpdateBrend(TblBrend brend);

        int DeleteBrend(TblBrend brend);

        TblBrend GetBrend(int Id);
        IEnumerable<TblBrend> GetBrends();
        
    }
}
