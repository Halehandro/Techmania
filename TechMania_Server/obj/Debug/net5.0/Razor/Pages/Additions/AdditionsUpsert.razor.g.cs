#pragma checksum "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e19172f5b969079e1644272a54f8f0f9093fed7"
// <auto-generated/>
#pragma warning disable 1591
namespace TechMania_Server.Pages.Additions
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using TechMania_Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
using TechMania_Server.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addition/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/addition/edit/{Id:int}")]
    public partial class AdditionsUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Addition");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                 AdditionModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                               HandleAdditionUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                AdditionModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AdditionModel.Name = __value, AdditionModel.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AdditionModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.Additions.AdditionsUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 22 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                () => AdditionModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Description</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(34);
                __builder2.AddAttribute(35, "rows", "3");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                             AdditionModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AdditionModel.Description = __value, AdditionModel.Description))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AdditionModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.Additions.AdditionsUpsert.TypeInference.CreateValidationMessage_1(__builder2, 41, 42, 
#nullable restore
#line 27 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                () => AdditionModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddAttribute(46, "style", "padding-top:70px;");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(47);
                __builder2.AddAttribute(48, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(49, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "row");
#nullable restore
#line 32 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(53, "<div><span><i class=\"fade fade-spin fa-spinner\">Please wait...Images are uploading...</i></span></div>");
#nullable restore
#line 37 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                             if (!string.IsNullOrEmpty(AdditionModel.IconStyle))
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-2 mt-3");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "room-image");
                __builder2.AddAttribute(58, "style", "background:" + " url(\'" + (
#nullable restore
#line 41 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                                                     AdditionModel.IconStyle

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%;");
                __builder2.OpenElement(59, "span");
                __builder2.AddAttribute(60, "class", "room-image-title");
                __builder2.AddContent(61, 
#nullable restore
#line 42 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                                        AdditionModel.IconStyle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                                    ");
                __builder2.OpenElement(63, "button");
                __builder2.AddAttribute(64, "type", "button");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                                    ()=>DeletePhoto(AdditionModel.IconStyle)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddContent(67, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.OpenElement(71, "button");
                __builder2.AddAttribute(72, "class", "btn btn-primary");
                __builder2.AddContent(73, 
#nullable restore
#line 51 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
                __builder2.AddAttribute(76, "href", "addition");
                __builder2.AddAttribute(77, "class", "btn btn-secondary");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(79, "Back");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\Additions\AdditionsUpsert.razor"
       
    [Parameter]
    public int? Id { get; set; }
    private AdditionDTO AdditionModel { get; set; } = new AdditionDTO();
    private string Title { get; set; } = "Create";
    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }

    private bool IsImageUploadProcessStarted { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationState;

        if (!authenticationState.User.IsInRole(Common.SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"identity/account/login?returnUrl={uri.LocalPath}");
        }

        if (Id != null)
        {
            //updating
            Title = "Update";
            AdditionModel = await AdditionRepository.GetAddition(Id.Value);
        }
        else
        {
            //create
            AdditionModel = new AdditionDTO();
        }
    }

    private async Task HandleAdditionUpsert()
    {
        try
        {
            if (Title == "Create")
            {
                var additionDetailsByName = await AdditionRepository.IsSameNameAdditionAlreadyExists(AdditionModel.Name);
                if (additionDetailsByName != null)
                {
                    //duplicates
                    await JsRuntime.ToastrError("Addition name already exists.");
                    return;
                }
            }

            if (AdditionModel.Id != 0 && Title == "Update")
            {
                //update
                var updateAdditionResult = await AdditionRepository.UpdateAddition(AdditionModel.Id, AdditionModel);

                await JsRuntime.ToastrSuccess("Addition updated successfully.");
            }
            else
            {
                //create
                //AdditionModel.Details = await QuillHtml.GetHTML();
                var createdResult = await AdditionRepository.CreateAddition(AdditionModel);
                await JsRuntime.ToastrSuccess("Addition created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
            return;
        }

        NavigationManager.NavigateTo("/addition");
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                       fileInfo.Extension.ToLower() == ".png" ||
                       fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        AdditionModel.IconStyle = uploadedImagePath;
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/ .jpeg/ .png file only");
                        return;
                    }
                }
                if (string.IsNullOrEmpty(AdditionModel.IconStyle))
                {
                    await JsRuntime.ToastrError("Image upload failed");
                    AdditionModel.IconStyle = "";
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
            throw ex;
        }
    }

    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageName = imageUrl.Replace($"PhoneImages/", "");
            var result = FileUpload.DeleteFile(imageName);
            if (result)
            {
                AdditionModel.IconStyle = string.Empty;
                await JsRuntime.ToastrSuccess("Image deleted successfully");
            }
            else
            {
                await JsRuntime.ToastrError("Image delete failed");
            }
        }
        catch (Exception ex)
        {
            await JsRuntime.ToastrError(ex.Message);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdditionRepository AdditionRepository { get; set; }
    }
}
namespace __Blazor.TechMania_Server.Pages.Additions.AdditionsUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
