using OnlineShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Services.Data;
using OnlineShop.DataAccess.Repositories.Base;
using OnlineShop.DataAccess.Repositories;
using OnlineShop.Services.Implementation.Dase;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Services.Implementation
{
    public class AssortmentServices : BaseService, IAssortmentServices
    {
        IAssortmentRepository _assortmentRepository;

       public AssortmentServices()
        {
            _assortmentRepository = new AssortmentRepository(context);
        }

        public int AddAssortment(Assortment assortment)
        {
            TblAssortment tb = new TblAssortment();
            tb.Article = assortment.Article;
            tb.Id = Guid.NewGuid();
            tb.Name = assortment.Name;
            tb.IdBrand = assortment.IdBrand;
            return _assortmentRepository.AddAssortment(tb);
        }

        public int AddAssortments(IEnumerable<Assortment> listAssortment)
        {
            int i = 0;
            foreach (Assortment item in listAssortment)
            {
                i += AddAssortment(item);
            }
            return i;
        }

        public int DeleteAssortment(Assortment assortment)
        {
            TblAssortment tb = new TblAssortment();
            tb.Article = assortment.Article;
            tb.Id = Guid.NewGuid();
            tb.Name = assortment.Name;
            tb.IdBrand = assortment.IdBrand;
            return _assortmentRepository.DeleteAssortment(tb);
        }

        public int DeleteAssortments(IEnumerable<Assortment> listAssortment)
        {
            int i = 0;
            foreach (Assortment item in listAssortment)
            {
                i += DeleteAssortment(item);
            }
            return i;
        }

        public Assortment GetAssortment(Guid Id)
        {
            var assortment = _assortmentRepository.GetAssortment(Id);
            Assortment a = new Assortment();
            a.Id = assortment.Id;
            a.Name = assortment.Name;
            a.Article = assortment.Article;
            a.IdBrand = assortment.IdBrand;
            return a;
        }

        public IEnumerable<Assortment> GetAssortments()
        {
            return _assortmentRepository.GetAssortments().Select(x => new Assortment
            {
                Id = x.Id,
                Article = x.Article,
                Name = x.Name,
                IdBrand = x.IdBrand
            });
        }

        public int UpdateAssortment(Assortment assortment)
        {
            TblAssortment tb = new TblAssortment();
            tb.Article = assortment.Article;
            tb.Id = assortment.Id;
            tb.Name = assortment.Name;
            tb.IdBrand = assortment.IdBrand;
            return _assortmentRepository.UpdateAssortment(tb);
        }

        public int UpdateAssortments(IEnumerable<Assortment> listAssortment)
        {
            int i = 0;
            foreach (Assortment item in listAssortment)
            {
                i += UpdateAssortment(item);
            }
            return i;
        }
    }
}
