﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository myrepository; 
       
        public ProductController (IProductRepository productRepository)
        {
            this.myrepository = productRepository;
        }

        public int PageSize = 4;
        public ViewResult List(int page = 1)
        {
            return View(myrepository.Products.OrderBy(p => p.ProductID).Skip((page -1) * PageSize).Take(PageSize));
        }
    }
}