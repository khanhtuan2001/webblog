#pragma checksum "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a6776bf0d4dd05e4a435e7ec55f5373574bb0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a6776bf0d4dd05e4a435e7ec55f5373574bb0e", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46584ec0aec1c0eea63e1dfdfe314f647fdcde84", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Webblog.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/{Model.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- section main content -->
<section class=""main-content mt-3"">
    <div class=""container-xl"">

        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 459, "\"", 483, 2);
            WriteAttributeValue("", 466, "/", 466, 1, true);
#nullable restore
#line 16 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
WriteAttributeValue("", 467, Model.Cat.Alias, 467, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                                                   Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 17 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </nav>

        <div class=""row gy-4"">

            <div class=""col-lg-8"">
                <!-- post single -->
                <div class=""post post-single"">
                    <!-- post header -->
                    <div class=""post-header"">
                        <h1 class=""title mt-0 mb-3"">");
#nullable restore
#line 28 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul class=\"meta list-inline mb-0\">\r\n                            <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1087, 1);
#nullable restore
#line 30 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1083, url, 1083, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/other/author-sm.png\" class=\"author\"");
            BeginWriteAttribute("alt", " alt=\"", 1141, "\"", 1160, 1);
#nullable restore
#line 30 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1147, Model.Author, 1147, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 30 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                                                                                                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1247, "\"", 1271, 2);
            WriteAttributeValue("", 1254, "/", 1254, 1, true);
#nullable restore
#line 31 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1255, Model.Cat.Alias, 1255, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                                                                Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"list-inline-item\">");
#nullable restore
#line 32 "D:\cshape\DoAnCoSo\Webblog\Views\Posts\Details.cshtml"
                                                    Write(Model.CreateDate.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                    <!-- featured image -->
                    <div class=""featured-image"">
                        <img src=""images/posts/featured-lg.jpg"" alt=""post-title"" />
                    </div>
                    <!-- post content -->
                    <div class=""post-content clearfix"">
                        <p>The European languages are members of the same family. Their separate existence is a myth. For science, music, sport, etc, Europe uses the same <a href=""#"">vocabulary</a>. The languages only differ in their grammar, their pronunciation and their most common words.</p>

                        <p>Everyone realizes why a new common language would be desirable: one could refuse to pay expensive translators. To achieve this, it <mark>would be</mark> necessary to have uniform grammar, pronunciation and more common words.</p>

                        <figure class=""figure"">
                            <img src=""image");
            WriteLiteral(@"s/posts/post-lg-2.jpg"" class=""figure-img img-fluid rounded"" alt=""..."">
                            <figcaption class=""figure-caption text-center"">A caption for the above image.</figcaption>
                        </figure>

                        <p>The languages only differ in their grammar, their pronunciation and their most common words. Everyone realizes why a new common language would be desirable.</p>

                        <img src=""images/posts/single-sm-1.jpg"" class=""rounded alignleft"" alt=""..."">
                        <p>One could refuse to pay expensive translators. To achieve this, it would be necessary to have uniform grammar, pronunciation and more common words.</p>

                        <p>If several languages coalesce, the grammar of the resulting language is more simple and regular than that of the individual languages. The new common language will be more simple and regular than the existing <a href=""#"">European languages</a>. It will be as simple as Occidental; in fact, it ");
            WriteLiteral(@"will be Occidental.</p>

                        <p>A collection of textile samples lay spread out on the table - Samsa was a travelling salesman - and above it there hung a picture that he had recently cut out of an illustrated magazine and housed in a nice, gilded frame.</p>

                        <h4>I should be incapable of drawing a single stroke</h4>

                        <ul>
                            <li>How about if I sleep a little bit</li>
                            <li>A collection of textile samples lay spread out</li>
                            <li>His many legs, pitifully thin compared with</li>
                            <li>He lay on his armour-like back</li>
                            <li> Gregor Samsa woke from troubled dreams</li>
                        </ul>

                        <p>To an English person, it will seem like simplified <a href=""#"">English</a>, as a skeptical Cambridge friend of mine told me what Occidental is. The European languages are members o");
            WriteLiteral(@"f the same family. Their separate existence is a myth. For science, music, sport, etc, Europe uses the same vocabulary.</p>
                    </div>
                    <!-- post bottom section -->
                    <div class=""post-bottom"">
                        <div class=""row d-flex align-items-center"">
                            <div class=""col-md-6 col-12 text-center text-md-start"">
                                <!-- tags -->
                                <a href=""#"" class=""tag"">#Trending</a>
                                <a href=""#"" class=""tag"">#Video</a>
                                <a href=""#"" class=""tag"">#Featured</a>
                            </div>
                            <div class=""col-md-6 col-12"">
                                <!-- social icons -->
                                <ul class=""social-icons list-unstyled list-inline mb-0 float-md-end"">
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i>");
            WriteLiteral(@"</a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>

                </div>

                <div class=""spacer"" data-height=""50""></div>

                <div class=""about-author padding-30 rounded"">
                    <div class=""thumb"">
                        <img src=""images/other/avatar-about.png"" alt=""Katen Doe");
            WriteLiteral(@""" />
                    </div>
                    <div class=""details"">
                        <h4 class=""name""><a href=""#"">Katen Doe</a></h4>
                        <p>Hello, I’m a content writer who is fascinated by content fashion, celebrity and lifestyle. She helps clients bring the right content to the right people.</p>
                        <!-- social icons -->
                        <ul class=""social-icons list-unstyled list-inline mb-0"">
                            <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                            <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                            <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                            <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                            <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
   ");
            WriteLiteral(@"                         <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                        </ul>
                    </div>
                </div>

                <div class=""spacer"" data-height=""50""></div>

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Comments (3)</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>
                <!-- post comments -->
                <div class=""comments bordered padding-30 rounded"">

                    <ul class=""comments"">
                        <!-- comment item -->
                        <li class=""comment rounded"">
                            <div class=""thumb"">
                                <img src=""images/other/comment-1.png"" alt=""John Doe"" />
                            </div>
                            <div class=""details"">
                                <h4 cla");
            WriteLiteral(@"ss=""name""><a href=""#"">John Doe</a></h4>
                                <span class=""date"">Jan 08, 2021 14:41 pm</span>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vitae odio ut tortor fringilla cursus sed quis odio.</p>
                                <a href=""#"" class=""btn btn-default btn-sm"">Reply</a>
                            </div>
                        </li>
                        <!-- comment item -->
                        <li class=""comment child rounded"">
                            <div class=""thumb"">
                                <img src=""images/other/comment-2.png"" alt=""John Doe"" />
                            </div>
                            <div class=""details"">
                                <h4 class=""name""><a href=""#"">Helen Doe</a></h4>
                                <span class=""date"">Jan 08, 2021 14:41 pm</span>
                                <p>Maecenas tempus, tellus eget condimentum rhoncus, sem quam sempe");
            WriteLiteral(@"r libero, sit amet adipiscing sem neque sed ipsum.</p>
                                <a href=""#"" class=""btn btn-default btn-sm"">Reply</a>
                            </div>
                        </li>
                        <!-- comment item -->
                        <li class=""comment rounded"">
                            <div class=""thumb"">
                                <img src=""images/other/comment-3.png"" alt=""John Doe"" />
                            </div>
                            <div class=""details"">
                                <h4 class=""name""><a href=""#"">Anna Doe</a></h4>
                                <span class=""date"">Jan 08, 2021 14:41 pm</span>
                                <p>Cras ultricies mi eu turpis hendrerit fringilla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia.</p>
                                <a href=""#"" class=""btn btn-default btn-sm"">Reply</a>
                            </div>
                        </li>
    ");
            WriteLiteral(@"                </ul>
                </div>

                <div class=""spacer"" data-height=""50""></div>

                <!-- section header -->
                <div class=""section-header"">
                    <h3 class=""section-title"">Leave Comment</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>
                <!-- comment form -->
                <div class=""comment-form rounded bordered padding-30"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08a6776bf0d4dd05e4a435e7ec55f5373574bb0e18868", async() => {
                WriteLiteral(@"

                        <div class=""messages""></div>

                        <div class=""row"">

                            <div class=""column col-md-12"">
                                <!-- Comment textarea -->
                                <div class=""form-group"">
                                    <textarea name=""InputComment"" id=""InputComment"" class=""form-control"" rows=""4"" placeholder=""Your comment here..."" required=""required""></textarea>
                                </div>
                            </div>

                            <div class=""column col-md-6"">
                                <!-- Email input -->
                                <div class=""form-group"">
                                    <input type=""email"" class=""form-control"" id=""InputEmail"" name=""InputEmail"" placeholder=""Email address"" required=""required"">
                                </div>
                            </div>

                            <div class=""column col-md-6"">
             ");
                WriteLiteral(@"                   <!-- Name input -->
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" name=""InputWeb"" id=""InputWeb"" placeholder=""Website"" required=""required"">
                                </div>
                            </div>

                            <div class=""column col-md-12"">
                                <!-- Email input -->
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" id=""InputName"" name=""InputName"" placeholder=""Your name"" required=""required"">
                                </div>
                            </div>

                        </div>

                        <button type=""submit"" name=""submit"" id=""submit"" value=""Submit"" class=""btn btn-default"">Submit</button><!-- Submit Button -->

                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-ite");
            WriteLiteral(@"m""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popular posts -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Popular Posts</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <!-- post -->
                            <div class=""post post-list-sm circle"">
       ");
            WriteLiteral(@"                         <div class=""thumb circle"">
                                    <span class=""number"">1</span>
                                    <a href=""blog-single.html"">
                                        <div class=""inner"">
                                            <img src=""images/posts/tabs-1.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""blog-single.html"">3 Easy Ways To Make Your iPhone Faster</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- post -->
                ");
            WriteLiteral(@"            <div class=""post post-list-sm circle"">
                                <div class=""thumb circle"">
                                    <span class=""number"">2</span>
                                    <a href=""blog-single.html"">
                                        <div class=""inner"">
                                            <img src=""images/posts/tabs-2.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""blog-single.html"">An Incredibly Easy Method That Works For All</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </");
            WriteLiteral(@"div>
                            <!-- post -->
                            <div class=""post post-list-sm circle"">
                                <div class=""thumb circle"">
                                    <span class=""number"">3</span>
                                    <a href=""blog-single.html"">
                                        <div class=""inner"">
                                            <img src=""images/posts/tabs-3.jpg"" alt=""post-title"" />
                                        </div>
                                    </a>
                                </div>
                                <div class=""details clearfix"">
                                    <h6 class=""post-title my-0""><a href=""blog-single.html"">10 Ways To Immediately Start Selling Furniture</a></h6>
                                    <ul class=""meta list-inline mt-1 mb-0"">
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
   ");
            WriteLiteral(@"                             </div>
                            </div>
                        </div>
                    </div>

                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Explore Topics</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <ul class=""list"">
                                <li><a href=""#"">Lifestyle</a><span>(5)</span></li>
                                <li><a href=""#"">Inspiration</a><span>(2)</span></li>
                                <li><a href=""#"">Fashion</a><span>(4)</span></li>
                                <li><a href=""#"">Politic</a><span>(1)</span></li>
                                <li><a href=""#"">Trending</a><span>(7)</span></li>
                   ");
            WriteLiteral(@"             <li><a href=""#"">Culture</a><span>(3)</span></li>
                            </ul>
                        </div>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08a6776bf0d4dd05e4a435e7ec55f5373574bb0e29760", async() => {
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
            WriteLiteral("tion>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Webblog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
