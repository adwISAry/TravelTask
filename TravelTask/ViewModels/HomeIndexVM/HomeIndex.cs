using TravelTask.Areas.Admin.ViewModels;

namespace TravelTask.ViewModels.HomeIndexVM
{
	public class HomeIndex
	{
		public IEnumerable<AdminProductListItemVM> Products { get; set; }
	}
}
