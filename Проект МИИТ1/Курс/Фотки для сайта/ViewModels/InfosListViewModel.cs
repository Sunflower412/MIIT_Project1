using WebCourse.Data.models;

namespace WebCourse.ViewModels
{
	public class InfosListViewModel
	{
		internal IEnumerable<Info> allInfos;
		internal string currCategory;

		public IEnumerable<Info> getAllInfos {  get; set; }
		
		public string infoCategory { get; set; }

		
	}
}
