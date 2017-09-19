using OnlineShop.Services.Data;
using OnlineShop.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.WebInterface.WebServices.Classec
{
    public class UpdateData
    {
        public UpdateData(Prices price)
        {
            BrendServices bs = new BrendServices();

           

            var res = bs.GetBrends().FirstOrDefault(x => x.BrendName == price.Brend);
            AssortmentServices ass = new AssortmentServices();
            if (res == null)
            {
                Brend br = new Brend();
                br.BrendName = price.Brend;
                br.Id = price.id;
                bs.AddBrand(br);

                var asss = ass.GetAssortments().FirstOrDefault(x => x.Article == price.Article);

                if (asss == null)
                {
                    Assortment a = new Assortment();
                    a.Id = Guid.NewGuid();
                    a.Article = price.Article;
                    a.Name = price.Name;
                    a.IdBrand = bs.GetBrends().FirstOrDefault(x => x.BrendName == price.Brend).Id;
                    ass.AddAssortment(a);
                }

            }
            else
            {
                var asss = ass.GetAssortments().FirstOrDefault(x => x.Article == price.Article);

                if (asss == null)
                {
                    Assortment a = new Assortment();
                    a.Id = Guid.NewGuid();
                    a.Article = price.Article;
                    a.Name = price.Name;
                    a.IdBrand = bs.GetBrends().FirstOrDefault(x => x.BrendName == price.Brend).Id;
                    ass.AddAssortment(a);
                }
            }

        }
    }
}