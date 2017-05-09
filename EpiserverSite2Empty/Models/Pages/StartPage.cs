using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverSite2Empty.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "fdf88539-ec3f-4896-a4af-d28ef66b45d0", Description = "")]
    public class StartPage : PageData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The RR2  release1 main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         
    }
}