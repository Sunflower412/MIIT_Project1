using WebCourse.Data.Interfaces;
using WebCourse.Data.models;

namespace WebCourse.Data.mocks
{
    public class mockCategory : IInformationCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Информация об АСУ СС", desc = "Здесь вы сможете найти нужную информацию об информационной системе" }            
                };
            }
        }
    }
}
