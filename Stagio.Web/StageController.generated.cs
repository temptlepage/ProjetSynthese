// <auto-generated />
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
namespace Stagio.Web.Controllers
{
	public partial class StageController
	{
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected StageController(Dummy d) { }

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToAction(ActionResult result)
		{
			var callInfo = result.GetT4MVCResult();
			return RedirectToRoute(callInfo.RouteValueDictionary);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
		{
			return RedirectToAction(taskResult.Result);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
		{
			var callInfo = result.GetT4MVCResult();
			return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
		{
			return RedirectToActionPermanent(taskResult.Result);
		}

		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult ViewStageInfo()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ViewStageInfo);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult Details()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public StageController Actions { get { return MVC.Stage; } }
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Area = "";
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Name = "Stage";
		[GeneratedCode("T4MVC", "2.0")]
		public const string NameConst = "Stage";

		static readonly ActionNamesClass s_actions = new ActionNamesClass();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionNamesClass ActionNames { get { return s_actions; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNamesClass
		{
			public readonly string ListNewStages = "ListNewStages";
			public readonly string ViewStageInfo = "ViewStageInfo";
			public readonly string Details = "Details";
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNameConstants
		{
			public const string ListNewStages = "ListNewStages";
			public const string ViewStageInfo = "ViewStageInfo";
			public const string Details = "Details";
		}


		static readonly ActionParamsClass_ViewStageInfo s_params_ViewStageInfo = new ActionParamsClass_ViewStageInfo();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_ViewStageInfo ViewStageInfoParams { get { return s_params_ViewStageInfo; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_ViewStageInfo
		{
			public readonly string id = "id";
		}
		static readonly ActionParamsClass_Details s_params_Details = new ActionParamsClass_Details();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_Details DetailsParams { get { return s_params_Details; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_Details
		{
			public readonly string id = "id";
			public readonly string command = "command";
		}
		static readonly ViewsClass s_views = new ViewsClass();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ViewsClass Views { get { return s_views; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ViewsClass
		{
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string Details = "Details";
                public readonly string ListNewStages = "ListNewStages";
                public readonly string ViewStageInfo = "ViewStageInfo";
            }
            public readonly string Details = "~/Views/Stage/Details.cshtml";
            public readonly string ListNewStages = "~/Views/Stage/ListNewStages.cshtml";
            public readonly string ViewStageInfo = "~/Views/Stage/ViewStageInfo.cshtml";
		}
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public partial class T4MVC_StageController : Stagio.Web.Controllers.StageController
	{
		public T4MVC_StageController() : base(Dummy.Instance) { }

		[NonAction]
		partial void ListNewStagesOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult ListNewStages()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ListNewStages);
			ListNewStagesOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void ViewStageInfoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult ViewStageInfo(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ViewStageInfo);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			ViewStageInfoOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult Details(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			DetailsOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void DetailsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string command, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult Details(string command, int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Details);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "command", command);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			DetailsOverride(callInfo, command, id);
			return callInfo;
		}

	}
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
