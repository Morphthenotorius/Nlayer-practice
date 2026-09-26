using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs.CategoryDTO;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void CreateCategory(CreateCategoryDTO model)
        {
            Category entity = new Category()
            {
                Name = model.Name,
            };

            _categoryDAL.Add(entity);
        }
    }
}
