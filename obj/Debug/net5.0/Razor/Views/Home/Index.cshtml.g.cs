#pragma checksum "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46bc0793e50b764efb309ebdeb1b9c1c76fee591"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\cshape\DoAnCoSo\Webblog\Views\_ViewImports.cshtml"
using Webblog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cshape\DoAnCoSo\Webblog\Views\_ViewImports.cshtml"
using Webblog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46bc0793e50b764efb309ebdeb1b9c1c76fee591", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46584ec0aec1c0eea63e1dfdfe314f647fdcde84", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webblog.ModelViews.HomeViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- hero section -->\r\n<section id=\"hero\">\r\n\r\n    <div class=\"container-xl\">\r\n\r\n        <div class=\"row gy-4\">\r\n");
#nullable restore
#line 13 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
             if (Model.Fetured != null)
            {
                string url = $"/{Model.Fetured.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-8\">\r\n\r\n                    <!-- featured post large -->\r\n                    <div class=\"post featured-post-lg\">\r\n                        <div class=\"details clearfix\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 587, 2);
            WriteAttributeValue("", 562, "/", 562, 1, true);
#nullable restore
#line 21 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 563, Model.Fetured.Cat.Alias, 563, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-badge\">");
#nullable restore
#line 21 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                                  Write(Model.Fetured.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <h2 class=\"post-title\"><a");
            BeginWriteAttribute("href", " href=\"", 697, "\"", 708, 1);
#nullable restore
#line 22 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 704, url, 704, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                             Write(Model.Fetured.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <ul class=\"meta list-inline mb-0\">\r\n                                <li class=\"list-inline-item\"><a href=\"#\">");
#nullable restore
#line 24 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                    Write(Model.Fetured.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"list-inline-item\">");
#nullable restore
#line 25 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                        Write(Model.Fetured.CreateDate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1127, "\"", 1138, 1);
#nullable restore
#line 28 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 1134, url, 1134, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""thumb rounded"">
                                <div class=""inner data-bg-image"" data-bg-image=""images/posts/featured-lg.jpg""></div>
                            </div>
                        </a>
                    </div>

                </div>
");
#nullable restore
#line 36 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            <div class=""col-lg-4"">

                <!-- post tabs -->
                <div class=""post-tabs rounded bordered"">
                    <!-- tab navs -->
                    <ul class=""nav nav-tabs nav-pills nav-fill"" id=""postsTab"" role=""tablist"">
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""popular"" aria-selected=""true"" class=""nav-link active"" data-bs-target=""#popular"" data-bs-toggle=""tab"" id=""popular-tab"" role=""tab"" type=""button"">Popular</button></li>
                        <li class=""nav-item"" role=""presentation""><button aria-controls=""recent"" aria-selected=""false"" class=""nav-link"" data-bs-target=""#recent"" data-bs-toggle=""tab"" id=""recent-tab"" role=""tab"" type=""button"">Recent</button></li>
                    </ul>
                    <!-- tab contents -->
                    <div class=""tab-content"" id=""postsTabContent"">
                        <!-- loader -->
                        <div class=""lds-dual-ring""></div>
                  ");
            WriteLiteral("      <!-- popular posts -->\r\n                        <div aria-labelledby=\"popular-tab\" class=\"tab-pane fade show active\" id=\"popular\" role=\"tabpanel\">\r\n");
#nullable restore
#line 54 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                             if (Model.Populars != null)
                            {
                                foreach (var item in Model.Populars)
                                {
                                    string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!-- post -->\r\n                                    <div class=\"post post-list-sm circle\">\r\n                                        <div class=\"thumb circle\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3138, "\"", 3149, 1);
#nullable restore
#line 62 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 3145, url, 3145, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    <img src=\"images/posts/tabs-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 3308, "\"", 3325, 1);
#nullable restore
#line 64 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 3314, item.Title, 3314, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details clearfix"">
                                            <h6 class=""post-title my-0""><a");
            BeginWriteAttribute("href", " href=\"", 3631, "\"", 3642, 1);
#nullable restore
#line 69 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 3638, url, 3638, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                            <ul class=\"meta list-inline mt-1 mb-0\">\r\n                                                <li class=\"list-inline-item\">");
#nullable restore
#line 71 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                        Write(item.CreateDate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 75 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>

        </div>

    </div>

</section>

<!-- section main content -->
<section class=""main-content"">
    <div class=""container-xl"">

        <div class=""row gy-4"">
            <div class=""col-lg-8"">

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Latest Posts</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>

                <div class=""padding-30 rounded bordered"">

                    <div class=""row"">


");
#nullable restore
#line 108 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                         if (Model.LatestPosts != null && Model.LatestPosts.Count > 0)
                        {
                            foreach (var item in Model.LatestPosts)
                            {
                                string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-md-12 col-sm-6"">
                                    <!-- post -->
                                    <div class=""post post-list clearfix"">
                                        <div class=""thumb rounded"">
                                            <span class=""post-format-sm"">
                                                <i class=""icon-picture""></i>
                                            </span>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 5568, "\"", 5579, 1);
#nullable restore
#line 120 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 5575, url, 5575, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <div class=\"inner\">\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 5708, "\"", 5737, 2);
            WriteAttributeValue("", 5714, "images/news/", 5714, 12, true);
#nullable restore
#line 122 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 5726, item.Thumb, 5726, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5738, "\"", 5755, 1);
#nullable restore
#line 122 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 5744, item.Title, 5744, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""details"">
                                            <ul class=""meta list-inline mb-3"">
                                                <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author""");
            BeginWriteAttribute("alt", " alt=\"", 6199, "\"", 6216, 1);
#nullable restore
#line 128 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 6205, item.Title, 6205, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 128 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                                                                                                             Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                                <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 6322, "\"", 6344, 1);
#nullable restore
#line 129 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 6329, item.Cat.Alias, 6329, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 129 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                                                  Write(item.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                                <li class=\"list-inline-item\">");
#nullable restore
#line 130 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                        Write(item.CreateDate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            </ul>\r\n                                            <h5 class=\"post-title\"><a");
            BeginWriteAttribute("href", " href=\"", 6625, "\"", 6636, 1);
#nullable restore
#line 132 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 6632, url, 6632, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 132 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                            <p class=\"excerpt mb-0\">");
#nullable restore
#line 133 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                                                               Write(item.Contents);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <div class=""post-bottom clearfix d-flex align-items-center"">
                                                <div class=""social-share me-auto"">
                                                    <button class=""toggle-button icon-share""></button>
                                                    <ul class=""icons list-unstyled list-inline mb-0"">
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                                        <li ");
            WriteLiteral(@"class=""list-inline-item""><a href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                                        <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                                    </ul>
                                                </div>
                                                <div class=""more-button float-end"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 8244, "\"", 8255, 1);
#nullable restore
#line 147 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
WriteAttributeValue("", 8251, url, 8251, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""icon-options""></span></a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 153 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"






                    </div>
                    <!-- load more button -->
                    <div class=""text-center"">
                        <button class=""btn btn-simple"">Load More</button>
                    </div>

                </div>

            </div>

            <div class=""col-lg-4"">

                <!-- sidebar -->
                <div class=""sidebar"">
                    <!-- widget about -->
                    <div class=""widget rounded"">
                        <div class=""widget-about data-bg-image text-center"" data-bg-image=""images/map-bg.png"">
                            <img src=""images/logo.svg"" alt=""logo"" class=""mb-4"" />
                            <p class=""mb-4"">Hello, We’re content writer who is fascinated by content fashion, celebrity and lifestyle. We helps clients bring the right content to the right people.</p>
                            <ul class=""social-icons list-unstyled list-inline mb-0"">
                                <li class=""list-");
            WriteLiteral(@"inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popular posts -->
                    ");
#nullable restore
#line 193 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Popular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Explore Topics</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        ");
#nullable restore
#line 201 "D:\cshape\DoAnCoSo\Webblog\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>

                    <!-- widget newsletter -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Newsletter</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <span class=""newsletter-headline text-center mb-3"">Join 70,000 subscribers!</span>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46bc0793e50b764efb309ebdeb1b9c1c76fee59123524", async() => {
                WriteLiteral(@"
                                <div class=""mb-2"">
                                    <input class=""form-control w-100 text-center"" placeholder=""Email address…"" type=""email"">
                                </div>
                                <button class=""btn btn-default btn-full"" type=""submit"">Sign Up</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <span class=""newsletter-privacy text-center mt-3"">By signing up, you agree to our <a href=""#"">Privacy Policy</a></span>
                        </div>
                    </div>

                    <!-- widget post carousel -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Celebration</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <div class=""post-carousel-widget"">
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a hre");
            WriteLiteral(@"f=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">");
            WriteLiteral(@"
                                        <a href=""category.html"" class=""category-badge position-absolute"">Trending</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-2.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">Master The Art Of Nature With These 7 Tips</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
           ");
            WriteLiteral(@"                     <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                  ");
            WriteLiteral(@"                      <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- carousel arrows -->
                            <div class=""slick-arrows-bot"">
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-prev slick-custom-buttons"" aria-label=""Previous""><i class=""icon-arrow-left""></i></button>
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-next slick-custom-buttons"" aria-label=""Next""><i class=""icon-arrow-right""></i></button>
                            </div>
                        </div>
                    </div>

                    <!-- widget advertisement -->
                    <div class=""widget no-container rounded text-md-center"">
                        <span class=""ads-title"">- Sponsored Ad -</span>
                        <a href=""#"" class=""widget-ads");
            WriteLiteral(@""">
                            <img src=""images/ads/ad-360.png"" alt=""Advertisement"" />
                        </a>
                    </div>

                    <!-- widget tags -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Tag Clouds</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" class=""tag"">#Featured</a>
                            <a href=""#"" class=""tag"">#Gallery</a>
                            <a href=""#"" class=""tag"">#Celebrities</a>
                        </div>
                    </div>

                </div>

            </div>

        </div>

    </div>
</sec");
            WriteLiteral("tion>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webblog.ModelViews.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
