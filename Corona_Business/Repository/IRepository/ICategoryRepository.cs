using Corona_Models;

namespace Corona_Business.Repository.IRepository
{
    // this cateogryrepo will be called from the server app
    public interface ICategoryRepository
    {
        public CategoryDTO Create(CategoryDTO objDTO);

        public CategoryDTO Update(CategoryDTO objDTO);

        public CategoryDTO Delete(int id);

        public CategoryDTO Get(int id);

        public IEnumerable<CategoryDTO> GetAll();
    }
}
