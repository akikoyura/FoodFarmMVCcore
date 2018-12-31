using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodFarmMVCcore.Models;

namespace FoodFarmMVCcore.Controllers
{
    public class HomeController :Controller
    {
        private IProductRepository ProductRepository;
    }
}
