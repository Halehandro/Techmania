#pragma checksum "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6861170e11e2771a70199d629dbd84062fecc93e"
// <auto-generated/>
#pragma warning disable 1591
namespace TechMania_Server.Pages.SmartPhone
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
#line 3 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
using TechMania_Server.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/smart-phone/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/smart-phone/edit/{Id:int}")]
    public partial class SmartPhoneUpsert : Microsoft.AspNetCore.Components.ComponentBase
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
#line 13 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " SmartPhone");
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
#line 17 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                 SmartPhoneModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                                 HandleSmartPhoneUpsert

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
#line 22 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                SmartPhoneModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SmartPhoneModel.Name = __value, SmartPhoneModel.Name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SmartPhoneModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 23 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                () => SmartPhoneModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label>Manufacturer</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                SmartPhoneModel.Manufacturer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SmartPhoneModel.Manufacturer = __value, SmartPhoneModel.Manufacturer))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SmartPhoneModel.Manufacturer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 28 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                () => SmartPhoneModel.Manufacturer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label>Available quantity</label>\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateInputNumber_2(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 32 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                  SmartPhoneModel.Quantity

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SmartPhoneModel.Quantity = __value, SmartPhoneModel.Quantity)), 50, () => SmartPhoneModel.Quantity);
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateValidationMessage_3(__builder2, 52, 53, 
#nullable restore
#line 33 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                () => SmartPhoneModel.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label>Price</label>\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateInputNumber_4(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 37 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                  SmartPhoneModel.Price

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SmartPhoneModel.Price = __value, SmartPhoneModel.Price)), 62, () => SmartPhoneModel.Price);
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert.TypeInference.CreateValidationMessage_5(__builder2, 64, 65, 
#nullable restore
#line 38 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                () => SmartPhoneModel.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddAttribute(69, "style", "height:250px;");
                __builder2.AddMarkupContent(70, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(71);
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                    SmartPhoneModel.Details

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SmartPhoneModel.Details = __value, SmartPhoneModel.Details))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SmartPhoneModel.Details));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddAttribute(79, "style", "padding-top:70px;");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(80);
                __builder2.AddAttribute(81, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "row");
#nullable restore
#line 79 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(86, "<div><span><i class=\"fade fade-spin fa-spinner\">Please wait...Images are uploading...</i></span></div>");
#nullable restore
#line 84 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                             if (SmartPhoneModel.ImageUrls != null && SmartPhoneModel.ImageUrls.Count > 0)
                            {
                                int serial = 1;
                                foreach (var phoneImage in SmartPhoneModel.ImageUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "col-md-2 mt-3");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "room-image");
                __builder2.AddAttribute(91, "style", "background:" + " url(\'" + (
#nullable restore
#line 91 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                                                         phoneImage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%;");
                __builder2.OpenElement(92, "span");
                __builder2.AddAttribute(93, "class", "room-image-title");
                __builder2.AddContent(94, 
#nullable restore
#line 92 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                                            serial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n                                        ");
                __builder2.OpenElement(96, "button");
                __builder2.AddAttribute(97, "type", "button");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                                        ()=>DeletePhoto(phoneImage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddContent(100, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 97 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.OpenElement(104, "button");
                __builder2.AddAttribute(105, "class", "btn btn-primary");
                __builder2.AddContent(106, 
#nullable restore
#line 103 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(108);
                __builder2.AddAttribute(109, "href", "smart-phone");
                __builder2.AddAttribute(110, "class", "btn btn-secondary");
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(112, "Back");
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
#line 112 "C:\Users\dhalusek\source\repos\TechMania\TechMania_Server\Pages\SmartPhone\SmartPhoneUpsert.razor"
       
    [Parameter]
    public int? Id { get; set; }
    private SmartPhoneDTO SmartPhoneModel { get; set; } = new SmartPhoneDTO();
    private string Title { get; set; } = "Create";
    private SmartPhoneImageDTO PhoneImage { get; set; } = new SmartPhoneImageDTO();
    private List<string> DeletedImageNames { get; set; } = new List<string>();
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
            SmartPhoneModel = await SmartPhoneRepository.GetSmartPhone(Id.Value);
            if (SmartPhoneModel.SmartPhoneImages != null)
            {
                SmartPhoneModel.ImageUrls = SmartPhoneModel.SmartPhoneImages.Select(U => U.PhoneImageUrl).ToList();
            }
            SetHTML();
        }
        else
        {
            //create
            SmartPhoneModel = new SmartPhoneDTO();
        }
    }

    private async Task HandleSmartPhoneUpsert()
    {
        try
        {
            if (Title == "Create")
            {
                var phoneDetailsByName = await SmartPhoneRepository.IsPhoneUnique(SmartPhoneModel.Name, SmartPhoneModel.Id);
                if (phoneDetailsByName != null)
                {
                    //duplicates
                    await JsRuntime.ToastrError("Phone name already exists.");
                    return;
                }
            }

            if (SmartPhoneModel.Id != 0 && Title == "Update")
            {
                //update
                var updatePhoneResult = await SmartPhoneRepository.UpdateSmartPhone(SmartPhoneModel.Id, SmartPhoneModel);
                if ((SmartPhoneModel.ImageUrls != null && SmartPhoneModel.ImageUrls.Any())
                    || (DeletedImageNames != null && DeletedImageNames.Any())
                    )
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"PhoneImages/", "");
                            var result = FileUpload.DeleteFile(imageName);
                            await SmartPhoneImagesRepository.DeleteSmartPhoneImageByImageUrl(deletedImageName);
                        }
                    }




                    await AddSmartPhoneImage(updatePhoneResult);
                }
                await JsRuntime.ToastrSuccess("SmartPhone updated successfully.");
            }
            else
            {
                //create
                //SmartPhoneModel.Details = await QuillHtml.GetHTML();
                var createdResult = await SmartPhoneRepository.CreateSmartPhone(SmartPhoneModel);
                await AddSmartPhoneImage(createdResult);
                await JsRuntime.ToastrSuccess("SmartPhone created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
            return;
        }

        NavigationManager.NavigateTo("/smart-phone");
    }

    public async void SetHTML()
    {
        if (string.IsNullOrEmpty(SmartPhoneModel.Details))
        {
            await this.QuillHtml.LoadHTMLContent(SmartPhoneModel.Details);
        }
    }

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>();
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
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/ .jpeg/ .png file only");
                        return;
                    }
                }
                if (images.Any())
                {
                    if (SmartPhoneModel.ImageUrls != null && SmartPhoneModel.ImageUrls.Any())
                    {
                        SmartPhoneModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        SmartPhoneModel.ImageUrls = new List<string>();
                        SmartPhoneModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image upload failed");
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

    private async Task AddSmartPhoneImage(SmartPhoneDTO phoneDetails)
    {
        foreach (var imageUrl in SmartPhoneModel.ImageUrls)
        {
            if (SmartPhoneModel.SmartPhoneImages == null || SmartPhoneModel.SmartPhoneImages.Where(x => x.PhoneImageUrl == imageUrl).Count() == 0)
            {
                PhoneImage = new SmartPhoneImageDTO()
                {
                    PhoneId = phoneDetails.Id,
                    PhoneImageUrl = imageUrl
                };
                await SmartPhoneImagesRepository.CreateSmartPhoneImage(PhoneImage);
            }
        }
    }

    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = SmartPhoneModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"PhoneImages/", "");
            if (SmartPhoneModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }
            SmartPhoneModel.ImageUrls.RemoveAt(imageIndex);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISmartPhoneImagesRepository SmartPhoneImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISmartPhoneRepository SmartPhoneRepository { get; set; }
    }
}
namespace __Blazor.TechMania_Server.Pages.SmartPhone.SmartPhoneUpsert
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
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
