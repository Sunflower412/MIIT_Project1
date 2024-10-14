namespace WebCourse.Data.models
{
    public class Info
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string shortDesc { get; set; }

        public string longDesc { get; set; }

        public string img {  get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }


    }
}
