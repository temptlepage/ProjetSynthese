﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
	public static Stagio.Web.Controllers.AccountController Account = new Stagio.Web.Controllers.T4MVC_AccountController();
	public static Stagio.Web.Controllers.ApplyController Apply = new Stagio.Web.Controllers.T4MVC_ApplyController();
	public static Stagio.Web.Controllers.CIController CI = new Stagio.Web.Controllers.T4MVC_CIController();
	public static Stagio.Web.Controllers.ContactEnterpriseController ContactEnterprise = new Stagio.Web.Controllers.T4MVC_ContactEnterpriseController();
	public static Stagio.Web.Controllers.CoordinatorController Coordinator = new Stagio.Web.Controllers.T4MVC_CoordinatorController();
	public static Stagio.Web.Controllers.HomeController Home = new Stagio.Web.Controllers.T4MVC_HomeController();
	public static Stagio.Web.Controllers.InterviewController Interview = new Stagio.Web.Controllers.T4MVC_InterviewController();
	public static Stagio.Web.Controllers.NotificationController Notification = new Stagio.Web.Controllers.T4MVC_NotificationController();
	public static Stagio.Web.Controllers.StageController Stage = new Stagio.Web.Controllers.T4MVC_StageController();
	public static Stagio.Web.Controllers.StudentController Student = new Stagio.Web.Controllers.T4MVC_StudentController();
	public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public class Dummy
	{
		private Dummy() { }
		public static Dummy Instance = new Dummy();
	}
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
	public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
	{
		this.InitMVCT4Result(area, controller, action, protocol);
	}
	 
	public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
	
	public string Controller { get; set; }
	public string Action { get; set; }
	public string Protocol { get; set; }
	public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public static class Scripts {
		private const string URLPATH = "~/Scripts";
		public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
		public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    	public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
    	public static readonly string bootstrap_datetimepicker_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-datetimepicker.min.js") ? Url("bootstrap-datetimepicker.min.js") : Url("bootstrap-datetimepicker.js");
    	public static readonly string bootstrap_datetimepicker_min_js = Url("bootstrap-datetimepicker.min.js");
    	public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
    	public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
    	public static readonly string datetimepicker_setup_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/datetimepicker-setup.min.js") ? Url("datetimepicker-setup.min.js") : Url("datetimepicker-setup.js");
    	public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
    	public static readonly string jquery_2_1_1_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.intellisense.min.js") ? Url("jquery-2.1.1.intellisense.min.js") : Url("jquery-2.1.1.intellisense.js");
    	public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
    	public static readonly string jquery_2_1_1_min_js = Url("jquery-2.1.1.min.js");
    	public static readonly string jquery_2_1_1_min_map = Url("jquery-2.1.1.min.map");
    	public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
    	public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
    	public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
    	public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
    	public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
    	public static readonly string less_1_4_1_min_js = Url("less-1.4.1.min.js");
    	public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
    	public static readonly string moment_with_locales_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/moment-with-locales.min.js") ? Url("moment-with-locales.min.js") : Url("moment-with-locales.js");
    	public static readonly string moment_with_locales_min_js = Url("moment-with-locales.min.js");
    	public static readonly string moment_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/moment.min.js") ? Url("moment.min.js") : Url("moment.js");
    	public static readonly string moment_min_js = Url("moment.min.js");
    	public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
    	public static readonly string respond_min_js = Url("respond.min.js");
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public static class Content {
		private const string URLPATH = "~/Content";
		public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
		public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    	public static class bootstrap {
    		private const string URLPATH = "~/Content/bootstrap";
    		public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
    		public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        	public static readonly string alerts_less = Url("alerts.less");
        	public static readonly string badges_less = Url("badges.less");
        	public static readonly string bootstrap_less = Url("bootstrap.less");
        	public static readonly string breadcrumbs_less = Url("breadcrumbs.less");
        	public static readonly string button_groups_less = Url("button-groups.less");
        	public static readonly string buttons_less = Url("buttons.less");
        	public static readonly string carousel_less = Url("carousel.less");
        	public static readonly string close_less = Url("close.less");
        	public static readonly string code_less = Url("code.less");
        	public static readonly string component_animations_less = Url("component-animations.less");
        	public static readonly string dropdowns_less = Url("dropdowns.less");
        	public static readonly string forms_less = Url("forms.less");
        	public static readonly string glyphicons_less = Url("glyphicons.less");
        	public static readonly string grid_less = Url("grid.less");
        	public static readonly string input_groups_less = Url("input-groups.less");
        	public static readonly string jumbotron_less = Url("jumbotron.less");
        	public static readonly string labels_less = Url("labels.less");
        	public static readonly string list_group_less = Url("list-group.less");
        	public static readonly string media_less = Url("media.less");
        	public static readonly string mixins_less = Url("mixins.less");
        	public static readonly string modals_less = Url("modals.less");
        	public static readonly string navbar_less = Url("navbar.less");
        	public static readonly string navs_less = Url("navs.less");
        	public static readonly string normalize_less = Url("normalize.less");
        	public static readonly string pager_less = Url("pager.less");
        	public static readonly string pagination_less = Url("pagination.less");
        	public static readonly string panels_less = Url("panels.less");
        	public static readonly string popovers_less = Url("popovers.less");
        	public static readonly string print_less = Url("print.less");
        	public static readonly string progress_bars_less = Url("progress-bars.less");
        	public static readonly string responsive_utilities_less = Url("responsive-utilities.less");
        	public static readonly string scaffolding_less = Url("scaffolding.less");
        	public static readonly string tables_less = Url("tables.less");
        	public static readonly string theme_less = Url("theme.less");
        	public static readonly string thumbnails_less = Url("thumbnails.less");
        	public static readonly string tooltip_less = Url("tooltip.less");
        	public static readonly string type_less = Url("type.less");
        	public static readonly string utilities_less = Url("utilities.less");
        	public static readonly string variables_less = Url("variables.less");
        	public static readonly string wells_less = Url("wells.less");
    	}
    
    	public static readonly string bootstrap_datetimepicker_min_css = Url("bootstrap-datetimepicker.min.css");
    	public static readonly string bootstrap_theme_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap-theme.min.css") ? Url("bootstrap-theme.min.css") : Url("bootstrap-theme.css");
    		 
    	public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
    	public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
    	public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
    		 
    	public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
    	public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
    	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    	public static class fonts {
    		private const string URLPATH = "~/Content/fonts";
    		public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
    		public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        	public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
        	public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
        	public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
        	public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
    	}
    
    	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    	public static class less {
    		private const string URLPATH = "~/Content/less";
    		public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
    		public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        	public static readonly string bootstrap_datetimepicker_build_less = Url("bootstrap-datetimepicker-build.less");
        	public static readonly string bootstrap_datetimepicker_less = Url("bootstrap-datetimepicker.less");
    	}
    
    	public static readonly string signin_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/signin.min.css") ? Url("signin.min.css") : Url("signin.css");
    		 
    	public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
    		 
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public static partial class Bundles
	{
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public static partial class Scripts {}
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public static partial class Styles {}
	}
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009


