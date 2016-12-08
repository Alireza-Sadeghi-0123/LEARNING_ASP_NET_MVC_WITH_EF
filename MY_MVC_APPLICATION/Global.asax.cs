﻿namespace MY_MVC_APPLICATION
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication()
		{
		}

		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();

			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
			FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilters.Filters);
		}
	}
}
