

using WebCourse.Data.models;

namespace WebCourse.Data.Interfaces
{
    public interface IInformationCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
