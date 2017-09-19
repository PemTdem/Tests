using Ninject;
using OnlineShop.DataAccess.Repositories;
using OnlineShop.DataAccess.Repositories.Base;
using OnlineShop.Domain.Entities;
using OnlineShop.Services.Abstract;
using OnlineShop.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShop.WebInterface.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;

        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            _kernel.Bind<DbContext>().To<DataContext>();

            _kernel.Bind<IBrendsReposipory>().To<BrendReposipory>();
            _kernel.Bind<IAssortmentRepository>().To<AssortmentRepository>();
            _kernel.Bind<IBrendServices>().To<BrendServices>();
            _kernel.Bind<IAssortmentServices>().To<AssortmentServices>();

        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                return null;

            return (IController)_kernel.Get(controllerType);
        }

    }
}