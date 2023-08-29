using Corona_Models;

namespace Corona_Business.Repository.IRepository
{
    // this cateogryrepo will be called from the server app
    public interface ICategoryRepository
    {
        public Task<CategoryDTO> Create(CategoryDTO objDTO);

        public Task<CategoryDTO> Update(CategoryDTO objDTO);

        public Task<int> Delete(int id);

        public Task<CategoryDTO> Get(int id);

        public Task<IEnumerable<CategoryDTO>> GetAll();
    }
}
