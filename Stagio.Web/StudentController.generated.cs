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
	public partial class StudentController
	{
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		protected StudentController(Dummy d) { }

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
		public virtual System.Web.Mvc.ActionResult ApplyStage()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyStage);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult ApplyRemoveConfirmation()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyRemoveConfirmation);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult ApplyReApplyConfirmation()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyReApplyConfirmation);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult Download()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Download);
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public StudentController Actions { get { return MVC.Student; } }
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Area = "";
		[GeneratedCode("T4MVC", "2.0")]
		public readonly string Name = "Student";
		[GeneratedCode("T4MVC", "2.0")]
		public const string NameConst = "Student";

		static readonly ActionNamesClass s_actions = new ActionNamesClass();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionNamesClass ActionNames { get { return s_actions; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNamesClass
		{
			public readonly string Index = "Index";
			public readonly string Create = "Create";
			public readonly string Edit = "Edit";
			public readonly string DisplayStageList = "DisplayStageList";
			public readonly string ApplyStage = "ApplyStage";
			public readonly string ApplyConfirmation = "ApplyConfirmation";
			public readonly string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
			public readonly string ApplyReApplyConfirmation = "ApplyReApplyConfirmation";
			public readonly string ApplyList = "ApplyList";
			public readonly string CreateConfirmation = "CreateConfirmation";
			public readonly string Download = "Download";
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNameConstants
		{
			public const string Index = "Index";
			public const string Create = "Create";
			public const string Edit = "Edit";
			public const string DisplayStageList = "DisplayStageList";
			public const string ApplyStage = "ApplyStage";
			public const string ApplyConfirmation = "ApplyConfirmation";
			public const string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
			public const string ApplyReApplyConfirmation = "ApplyReApplyConfirmation";
			public const string ApplyList = "ApplyList";
			public const string CreateConfirmation = "CreateConfirmation";
			public const string Download = "Download";
		}


		static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_Create
		{
			public readonly string createStudentViewModel = "createStudentViewModel";
		}
		static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_Edit
		{
			public readonly string editStudentViewModel = "editStudentViewModel";
		}
		static readonly ActionParamsClass_ApplyStage s_params_ApplyStage = new ActionParamsClass_ApplyStage();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_ApplyStage ApplyStageParams { get { return s_params_ApplyStage; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_ApplyStage
		{
			public readonly string id = "id";
			public readonly string files = "files";
			public readonly string applyStudentViewModel = "applyStudentViewModel";
		}
		static readonly ActionParamsClass_ApplyRemoveConfirmation s_params_ApplyRemoveConfirmation = new ActionParamsClass_ApplyRemoveConfirmation();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_ApplyRemoveConfirmation ApplyRemoveConfirmationParams { get { return s_params_ApplyRemoveConfirmation; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_ApplyRemoveConfirmation
		{
			public readonly string id = "id";
		}
		static readonly ActionParamsClass_ApplyReApplyConfirmation s_params_ApplyReApplyConfirmation = new ActionParamsClass_ApplyReApplyConfirmation();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_ApplyReApplyConfirmation ApplyReApplyConfirmationParams { get { return s_params_ApplyReApplyConfirmation; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_ApplyReApplyConfirmation
		{
			public readonly string id = "id";
		}
		static readonly ActionParamsClass_Download s_params_Download = new ActionParamsClass_Download();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_Download DownloadParams { get { return s_params_Download; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_Download
		{
			public readonly string file = "file";
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
                public readonly string ApplyConfirmation = "ApplyConfirmation";
                public readonly string ApplyList = "ApplyList";
                public readonly string ApplyReApplyConfirmation = "ApplyReApplyConfirmation";
                public readonly string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
                public readonly string ApplyStage = "ApplyStage";
                public readonly string Create = "Create";
                public readonly string CreateConfirmation = "CreateConfirmation";
                public readonly string DisplayStageList = "DisplayStageList";
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
                public readonly string ReplyStage = "ReplyStage";
                public readonly string UploadCVLetter = "UploadCVLetter";
            }
            public readonly string ApplyConfirmation = "~/Views/Student/ApplyConfirmation.cshtml";
            public readonly string ApplyList = "~/Views/Student/ApplyList.cshtml";
            public readonly string ApplyReApplyConfirmation = "~/Views/Student/ApplyReApplyConfirmation.cshtml";
            public readonly string ApplyRemoveConfirmation = "~/Views/Student/ApplyRemoveConfirmation.cshtml";
            public readonly string ApplyStage = "~/Views/Student/ApplyStage.cshtml";
            public readonly string Create = "~/Views/Student/Create.cshtml";
            public readonly string CreateConfirmation = "~/Views/Student/CreateConfirmation.cshtml";
            public readonly string DisplayStageList = "~/Views/Student/DisplayStageList.cshtml";
            public readonly string Edit = "~/Views/Student/Edit.cshtml";
            public readonly string Index = "~/Views/Student/Index.cshtml";
            public readonly string ReplyStage = "~/Views/Student/ReplyStage.cshtml";
            public readonly string UploadCVLetter = "~/Views/Student/UploadCVLetter.cshtml";
		}
	}

	[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
	public partial class T4MVC_StudentController : Stagio.Web.Controllers.StudentController
	{
		public T4MVC_StudentController() : base(Dummy.Instance) { }

		[NonAction]
		partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult Index()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
			IndexOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult Create()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
			CreateOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Stagio.Web.ViewModels.Student.Create createStudentViewModel);

		[NonAction]
		public override System.Web.Mvc.ActionResult Create(Stagio.Web.ViewModels.Student.Create createStudentViewModel)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "createStudentViewModel", createStudentViewModel);
			CreateOverride(callInfo, createStudentViewModel);
			return callInfo;
		}

		[NonAction]
		partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult Edit()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
			EditOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Stagio.Web.ViewModels.Student.Edit editStudentViewModel);

		[NonAction]
		public override System.Web.Mvc.ActionResult Edit(Stagio.Web.ViewModels.Student.Edit editStudentViewModel)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "editStudentViewModel", editStudentViewModel);
			EditOverride(callInfo, editStudentViewModel);
			return callInfo;
		}

		[NonAction]
		partial void DisplayStageListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult DisplayStageList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DisplayStageList);
			DisplayStageListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void ApplyStageOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyStage(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyStage);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			ApplyStageOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void ApplyStageOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files, Stagio.Web.ViewModels.Student.Apply applyStudentViewModel);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyStage(System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files, Stagio.Web.ViewModels.Student.Apply applyStudentViewModel)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyStage);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "files", files);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "applyStudentViewModel", applyStudentViewModel);
			ApplyStageOverride(callInfo, files, applyStudentViewModel);
			return callInfo;
		}

		[NonAction]
		partial void ApplyConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyConfirmation()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyConfirmation);
			ApplyConfirmationOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void ApplyRemoveConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyRemoveConfirmation(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyRemoveConfirmation);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			ApplyRemoveConfirmationOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void ApplyReApplyConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyReApplyConfirmation(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyReApplyConfirmation);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			ApplyReApplyConfirmationOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void ApplyListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyList);
			ApplyListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void CreateConfirmationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult CreateConfirmation()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateConfirmation);
			CreateConfirmationOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void DownloadOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string file);

		[NonAction]
		public override System.Web.Mvc.ActionResult Download(string file)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Download);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
			DownloadOverride(callInfo, file);
			return callInfo;
		}

	}
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
