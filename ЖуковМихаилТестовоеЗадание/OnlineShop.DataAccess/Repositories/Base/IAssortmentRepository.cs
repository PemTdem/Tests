using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DataAccess.Repositories.Base
{
    public  interface IAssortmentRepository
    {
        int AddAssortment(TblAssortment assortment);

        int UpdateAssortment(TblAssortment assortment);

        int DeleteAssortment(TblAssortment assortment);

        TblAssortment GetAssortment(Guid Id);
        IEnumerable<TblAssortment> GetAssortments();

    }
}
