using System.Web;
using System.Web.Mvc;

namespace KnockoutJS_Examples
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters( GlobalFilterCollection filters )
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}