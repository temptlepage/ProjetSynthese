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
		public virtual System.Web.Mvc.ActionResult UploadPost()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadPost);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult Edit()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult Apply()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Apply);
		}
		[NonAction]
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public virtual System.Web.Mvc.ActionResult ApplyRemoveConfirmation()
		{
			return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyRemoveConfirmation);
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
			public readonly string Upload = "Upload";
			public readonly string UploadPost = "Upload";
			public readonly string ResultCreateList = "ResultCreateList";
			public readonly string PostResultCreateList = "ResultCreateList";
			public readonly string CreateList = "CreateList";
			public readonly string CreateListPost = "CreateList";
			public readonly string Create = "Create";
			public readonly string Edit = "Edit";
			public readonly string StageList = "StageList";
			public readonly string Apply = "Apply";
			public readonly string ApplyConfirmation = "ApplyConfirmation";
<<<<<<< HEAD
			public readonly string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
=======
>>>>>>> 2b29837f623b5727a2254730655231e0dfdeda11
			public readonly string ApplyList = "ApplyList";
		}

		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionNameConstants
		{
			public const string Index = "Index";
			public const string Upload = "Upload";
			public const string UploadPost = "Upload";
			public const string ResultCreateList = "ResultCreateList";
			public const string PostResultCreateList = "ResultCreateList";
			public const string CreateList = "CreateList";
			public const string CreateListPost = "CreateList";
			public const string Create = "Create";
			public const string Edit = "Edit";
			public const string StageList = "StageList";
			public const string Apply = "Apply";
			public const string ApplyConfirmation = "ApplyConfirmation";
<<<<<<< HEAD
			public const string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
=======
>>>>>>> 2b29837f623b5727a2254730655231e0dfdeda11
			public const string ApplyList = "ApplyList";
		}


		static readonly ActionParamsClass_UploadPost s_params_UploadPost = new ActionParamsClass_UploadPost();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_UploadPost UploadPostParams { get { return s_params_UploadPost; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_UploadPost
		{
			public readonly string file = "file";
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
			public readonly string id = "id";
			public readonly string editStudentViewModel = "editStudentViewModel";
		}
		static readonly ActionParamsClass_Apply s_params_Apply = new ActionParamsClass_Apply();
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public ActionParamsClass_Apply ApplyParams { get { return s_params_Apply; } }
		[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
		public class ActionParamsClass_Apply
		{
			public readonly string id = "id";
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
                public readonly string Apply = "Apply";
                public readonly string ApplyConfirmation = "ApplyConfirmation";
                public readonly string ApplyList = "ApplyList";
<<<<<<< HEAD
                public readonly string ApplyRemoveConfirmation = "ApplyRemoveConfirmation";
=======
>>>>>>> 2b29837f623b5727a2254730655231e0dfdeda11
                public readonly string Create = "Create";
                public readonly string CreateList = "CreateList";
                public readonly string Edit = "Edit";
                public readonly string Index = "Index";
                public readonly string ResultCreateList = "ResultCreateList";
                public readonly string StageList = "StageList";
                public readonly string Upload = "Upload";
            }
            public readonly string Apply = "~/Views/Student/Apply.cshtml";
            public readonly string ApplyConfirmation = "~/Views/Student/ApplyConfirmation.cshtml";
            public readonly string ApplyList = "~/Views/Student/ApplyList.cshtml";
<<<<<<< HEAD
            public readonly string ApplyRemoveConfirmation = "~/Views/Student/ApplyRemoveConfirmation.cshtml";
=======
>>>>>>> 2b29837f623b5727a2254730655231e0dfdeda11
            public readonly string Create = "~/Views/Student/Create.cshtml";
            public readonly string CreateList = "~/Views/Student/CreateList.cshtml";
            public readonly string Edit = "~/Views/Student/Edit.cshtml";
            public readonly string Index = "~/Views/Student/Index.cshtml";
            public readonly string ResultCreateList = "~/Views/Student/ResultCreateList.cshtml";
            public readonly string StageList = "~/Views/Student/StageList.cshtml";
            public readonly string Upload = "~/Views/Student/Upload.cshtml";
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
		partial void UploadOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult Upload()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Upload);
			UploadOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void UploadPostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Web.HttpPostedFileBase file);

		[NonAction]
		public override System.Web.Mvc.ActionResult UploadPost(System.Web.HttpPostedFileBase file)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UploadPost);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
			UploadPostOverride(callInfo, file);
			return callInfo;
		}

		[NonAction]
		partial void ResultCreateListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult ResultCreateList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ResultCreateList);
			ResultCreateListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void PostResultCreateListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult PostResultCreateList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.PostResultCreateList);
			PostResultCreateListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void CreateListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult CreateList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateList);
			CreateListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void CreateListPostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult CreateListPost()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateListPost);
			CreateListPostOverride(callInfo);
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
		partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult Edit(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			EditOverride(callInfo, id);
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
		partial void StageListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult StageList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.StageList);
			StageListOverride(callInfo);
			return callInfo;
		}

		[NonAction]
		partial void ApplyOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int id);

		[NonAction]
		public override System.Web.Mvc.ActionResult Apply(int id)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Apply);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
			ApplyOverride(callInfo, id);
			return callInfo;
		}

		[NonAction]
		partial void ApplyOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Stagio.Web.ViewModels.Student.Apply applyStudentViewModel);

		[NonAction]
		public override System.Web.Mvc.ActionResult Apply(Stagio.Web.ViewModels.Student.Apply applyStudentViewModel)
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Apply);
			ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "applyStudentViewModel", applyStudentViewModel);
			ApplyOverride(callInfo, applyStudentViewModel);
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
<<<<<<< HEAD
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
=======
>>>>>>> 2b29837f623b5727a2254730655231e0dfdeda11
		partial void ApplyListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

		[NonAction]
		public override System.Web.Mvc.ActionResult ApplyList()
		{
			var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ApplyList);
			ApplyListOverride(callInfo);
			return callInfo;
		}

	}
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
