using WebCourse.Data.models;

namespace WebCourse.Data.Interfaces
{
    public interface IAllAbillities
    {
        IEnumerable<Info> Infos { get; }
        Info getObjectInfo(int id);

    }
}
