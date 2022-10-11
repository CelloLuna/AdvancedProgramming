using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel mykernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            mykernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type myserviceType)
        {
            return mykernel.GetAll(myserviceType);
        }
        public IEnumerable<object> GetServices(Type myserviceType)
        {
            return mykernel.GetAll(myserviceType);
        }

        private void AddBindings()
        {
            /*Mock<IProductRepository> myMock = new Mock<IProductRepository>();
            myMock.Setup(m => m.Products).Returns(new List<Product>{
                new Product {  Name = "Football", Price = 25},
                new Product {  Name = "Surf Board", Price = 179},
                new Product {  Name = "Running Shoes", Price = 95}
            });
            mykernel.Bind<IProductRepository>().ToConstant(myMock.Object);*/

            mykernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}