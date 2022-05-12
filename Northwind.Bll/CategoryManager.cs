using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class CategoryManager : GenericManager<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryManager(IServiceProvider service) : base(service)
        {

        }
    }
}
