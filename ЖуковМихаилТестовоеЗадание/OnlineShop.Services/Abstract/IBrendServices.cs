using OnlineShop.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Abstract
{
    public interface IBrendServices
    {
        int AddBrand(Brend brend);
        int AddBrends(IEnumerable<Brend> listBrends);

        int UpdateBrend(Brend brend);
        int UpdateBrends(IEnumerable<Brend> listBrends);

        int DeleteBrend(Brend brend);
        int DeleteBrends(IEnumerable<Brend> listBrends);

        Brend GetBrend(int Id);
        IEnumerable<Brend> GetBrends();
    }
}
