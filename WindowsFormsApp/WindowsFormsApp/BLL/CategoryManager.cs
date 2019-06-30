using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategorySetup.Models;


namespace CategorySetup.BLL
{
    public class CategoryManager
    {

        CategoryRepository  _categoryRepository = new CategoryRepository();

        public int Insert(Category category)
        {
            return _categoryRepository.Insert(category);

        }

        public DataTable ShowCategory()
        {
            return _categoryRepository.ShowCategory();
        }

     
    }
}
