using OnlineShop.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Abstract
{
    public interface IAssortmentServices
    {
        int AddAssortment(Assortment assortment);
        int AddAssortments(IEnumerable<Assortment> listAssortment);

        int UpdateAssortment(Assortment assortment);
        int UpdateAssortments(IEnumerable<Assortment> listAssortment);

        int DeleteAssortment(Assortment assortment);
        int DeleteAssortments(IEnumerable<Assortment> listAssortment);

        Assortment GetAssortment(Guid Id);
        IEnumerable<Assortment> GetAssortments();
    }
}
