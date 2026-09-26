using Entities.DTOs.CategoryDTO;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public void CreateCategory(CreateCategoryDTO model);
    }
}
