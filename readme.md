Umbraco-Razor-Components
========================

Helper extensions for razor support in Umbraco 4.x

This Library adds 2 new features to RazorLibraryCore (`@Library.XXX()`)


##1. RenderMacro

RenderMacro has 2 modes;

First can be called using 

`
@Library.RenderMacro("MacroAlias", new { Property1 = "value", Prop2= "value2"})
`

this will render a named macro from the back office. 


Second can be called with a path to a razor macro script in the form 

`
@Library.RenderMacro("~/macroScripts/scriptFile.cshtml", new { Property1 = "value", Prop2= "value2"})
`

this doesn't need to have been registered in the back office to work.

##2. ImageUrl/ImageUrls

This call can be used to retrieve a one or more crop urls form a media picker property (also supports DAMP and embedded media xml)

`
@Library.ImageUrl("imagePropertyAlias", "aliasOfCropPropertyOnMediaNode", "cropName")
`

this calls falls back to using the umbracoFile property if needs must.


##Compatibility

This is compatible with normal Umbraco Razor macros an also from within views using the UmbraMVCo library