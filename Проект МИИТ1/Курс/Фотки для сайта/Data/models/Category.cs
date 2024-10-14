namespace WebCourse.Data.models
{
    public class Category
    {
        public int Id { set; get; }

        public string CategoryName { set; get; }

        public string desc { set; get; }

       public List<Info> infos { set; get; }
    }
}
