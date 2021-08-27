<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588450/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2484)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [NewValuesController.cs](./CS/NewObjectInit.Module/NewValuesController.cs) (VB: [NewValuesController.vb](./VB/NewObjectInit.Module/NewValuesController.vb))
* [WebApplication.cs](./CS/NewObjectInit.Web/ApplicationCode/WebApplication.cs) (VB: [WebApplication.vb](./VB/NewObjectInit.Web/ApplicationCode/WebApplication.vb))
<!-- default file list end -->
# How to copy last entered values into a newly created object, when using the Save and New action


<p>This example covers a situation when an end-user fills DetailView information in batch mode. Sometimes it's necessary to duplicate last entered items into a new DetailView form.<br />
For implementation details, please refer to the platform-independent NewValuesController class (see the NewObjectInit.Module project).<br />
Basically, the current object is saved when the Save and New action is executed. After a new DetailView is initialized, the new object is updated using the previous object details.</p>

<br/>


