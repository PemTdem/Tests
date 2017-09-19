using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services.Implementation.Dase
{
    public class BaseService
    {
       public DataContext context = new DataContext();
    }
}
