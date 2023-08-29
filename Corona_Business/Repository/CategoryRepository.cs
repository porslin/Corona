
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
        public async Task<CategoryDTO> Create(CategoryDTO objDTO)
        {
            // cleaning conversion of Category class to CategoryDTO and vice versa using AutoMapper. 
            var obj = _mapper.Map<CategoryDTO, Category>(objDTO);

            obj.CreatedDate = DateTime.Now;

            var addedObj = _db.Categories.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Category, CategoryDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            // in order to delete, first you need to retrieve that category from db. use firstOrDefault to retrieve that categ from db. firstOrDefault retrieves based on the condition you declare, ie, where u.Id is equal to the  id received in the parameter above.
            var obj = await _db.Categories.FirstOrDefaultAsync(u => u.Id == id);

            if(obj != null)
            {
                _db.Categories.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<CategoryDTO> Get(int id)
        {
            var obj = await _db.Categories.FirstOrDefaultAsync(u => u.Id == id);

            if (obj != null)
            {
                return _mapper.Map<Category, CategoryDTO>(obj);
            }
            return new CategoryDTO();
        }

        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            // here you are converting lists of category to a list of categoryDTO
            return _mapper.Map<IEnumerable<Category>,IEnumerable<CategoryDTO>>(_db.Categories);
        }

        public async Task<CategoryDTO> Update(CategoryDTO objDTO)
        {
            var objFromDb = await _db.Categories.FirstOrDefaultAsync(u => u.Id == objDTO.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = objDTO.Name;
                _db.Categories.Update(objFromDb);
                _db.SaveChangesAsync();
                return _mapper.Map<Category, CategoryDTO>(objFromDb);
            }
            return objDTO;
        }

    }
}

// once this repository is setup, performing crud operations is the next step. 
