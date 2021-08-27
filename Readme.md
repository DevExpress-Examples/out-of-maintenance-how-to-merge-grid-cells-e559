<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630452/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E559)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication93/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication93/Form1.vb))
* [Program.cs](./CS/WindowsApplication93/Program.cs) (VB: [Program.vb](./VB/WindowsApplication93/Program.vb))
<!-- default file list end -->
# How to merge grid cells


<p>The sample illustrates the way to merge grid cells based on a custom-defined rule. To enable cell merging, it's necessary to set the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraGridViewsGridGridOptionsView_AllowCellMergetopic">GridView.OptionsView.AllowCellMerge</a> property to <strong>true</strong>. If you don't want to merge some columns, set the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraGridColumnsOptionsColumn_AllowMergetopic">GridColumn.OptionsColumn.AllowMerge</a> property to <strong>false</strong>. A merging rule is defined using the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraGridViewsGridGridView_CellMergetopic">GridView.CellMerge</a> event.</p>

<br/>


