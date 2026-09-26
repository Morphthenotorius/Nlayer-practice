using Core.Repositories.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EFCategoryDAL : EFRepositoryBase<Category, AppDbContext>, ICategoryDAL
    {
    }
}
