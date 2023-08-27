using Corona_Business.Repository.IRepository;
using Corona_DataAccess.Data;
using Corona_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_Business.Repository
{
    internal class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public CategoryDTO Create(CategoryDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Update(CategoryDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
