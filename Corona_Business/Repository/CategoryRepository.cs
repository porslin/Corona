
using Microsoft.EntityFrameworkCore;
using Corona_Business.Repository.IRepository;
using Corona_DataAccess.Data;
using Corona_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corona_DataAccess;
using AutoMapper;

namespace Corona_Business.Repository
{
    // since the DbContext is added and configured in the services, it can be extracted in the ctor here.
    public class CategoryRepository : ICategoryRepository
    {
        // first create a private readonly applicationdbcontext. (needs ref to Corona_DataAccess)
        public readonly ApplicationDbContext _db;
        public readonly IMapper _mapper;

        // then create ctor. and receive ApplicationDbContext built in with dependency injection
        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            // since it is injected, assign that to the local _db. so then using _db it is possible to perform crud operations on the DbSet. 
            _db = db;
            _mapper = mapper;
        }

        // when you have to create a category inside the create method, you first need to convert the CategoryDTO to a category object
        public CategoryDTO Create(CategoryDTO objDTO)
        {
            // cleaning conversion of Category class to CategoryDTO and vice versa using AutoMapper. 
            var obj = _mapper.Map<CategoryDTO, Category>(objDTO);

            var addedObj = _db.Categories.Add(obj);
            _db.SaveChanges();

            return _mapper.Map<Category, CategoryDTO>(addedObj.Entity);
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

        int ICategoryRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
