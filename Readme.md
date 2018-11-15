<!-- default file list -->
*Files to look at*:

* [CodeCentralExampleInMemoryDataStoreProvider.cs](./CS/NewObjectInit.Module/CodeCentralExampleInMemoryDataStoreProvider.cs) (VB: [CodeCentralExampleInMemoryDataStoreProvider.vb](./VB/NewObjectInit.Module/CodeCentralExampleInMemoryDataStoreProvider.vb))
* [Model.DesignedDiffs.xafml](./CS/NewObjectInit.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/NewObjectInit.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/NewObjectInit.Module/Module.cs) (VB: [Module.vb](./VB/NewObjectInit.Module/Module.vb))
* [NewValuesController.cs](./CS/NewObjectInit.Module/NewValuesController.cs) (VB: [NewValuesController.vb](./VB/NewObjectInit.Module/NewValuesController.vb))
* [Updater.cs](./CS/NewObjectInit.Module/Updater.cs) (VB: [Updater.vb](./VB/NewObjectInit.Module/Updater.vb))
* [WebApplication.cs](./CS/NewObjectInit.Web/ApplicationCode/WebApplication.cs) (VB: [WebApplication.vb](./VB/NewObjectInit.Web/ApplicationCode/WebApplication.vb))
* [Default.aspx](./CS/NewObjectInit.Web/Default.aspx) (VB: [Default.aspx.vb](./VB/NewObjectInit.Web/Default.aspx.vb))
* [Default.aspx.cs](./CS/NewObjectInit.Web/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/NewObjectInit.Web/Default.aspx.vb))
* [DefaultVertical.aspx](./CS/NewObjectInit.Web/DefaultVertical.aspx) (VB: [DefaultVertical.aspx](./VB/NewObjectInit.Web/DefaultVertical.aspx))
* [DefaultVertical.aspx.cs](./CS/NewObjectInit.Web/DefaultVertical.aspx.cs) (VB: [DefaultVertical.aspx](./VB/NewObjectInit.Web/DefaultVertical.aspx))
* [Dialog.aspx](./CS/NewObjectInit.Web/Dialog.aspx) (VB: [Dialog.aspx](./VB/NewObjectInit.Web/Dialog.aspx))
* [Dialog.aspx.cs](./CS/NewObjectInit.Web/Dialog.aspx.cs) (VB: [Dialog.aspx](./VB/NewObjectInit.Web/Dialog.aspx))
* [Error.aspx](./CS/NewObjectInit.Web/Error.aspx) (VB: [Error.aspx.vb](./VB/NewObjectInit.Web/Error.aspx.vb))
* [Error.aspx.cs](./CS/NewObjectInit.Web/Error.aspx.cs) (VB: [Error.aspx.vb](./VB/NewObjectInit.Web/Error.aspx.vb))
* [Global.asax](./CS/NewObjectInit.Web/Global.asax) (VB: [Global.asax.vb](./VB/NewObjectInit.Web/Global.asax.vb))
* [Global.asax.cs](./CS/NewObjectInit.Web/Global.asax.cs) (VB: [Global.asax.vb](./VB/NewObjectInit.Web/Global.asax.vb))
* [Login.aspx](./CS/NewObjectInit.Web/Login.aspx) (VB: [Login.aspx.vb](./VB/NewObjectInit.Web/Login.aspx.vb))
* [Login.aspx.cs](./CS/NewObjectInit.Web/Login.aspx.cs) (VB: [Login.aspx.vb](./VB/NewObjectInit.Web/Login.aspx.vb))
* [Model.xafml](./CS/NewObjectInit.Web/Model.xafml) (VB: [Model.xafml](./VB/NewObjectInit.Web/Model.xafml))
* [MoveFooter.js](./CS/NewObjectInit.Web/MoveFooter.js) (VB: [MoveFooter.js](./VB/NewObjectInit.Web/MoveFooter.js))
* [NestedFrameControl.ascx](./CS/NewObjectInit.Web/NestedFrameControl.ascx) (VB: [NestedFrameControl.ascx.vb](./VB/NewObjectInit.Web/NestedFrameControl.ascx.vb))
* [NestedFrameControl.ascx.cs](./CS/NewObjectInit.Web/NestedFrameControl.ascx.cs) (VB: [NestedFrameControl.ascx.vb](./VB/NewObjectInit.Web/NestedFrameControl.ascx.vb))
* [SessionKeepAliveReconnect.aspx](./CS/NewObjectInit.Web/SessionKeepAliveReconnect.aspx) (VB: [SessionKeepAliveReconnect.aspx.vb](./VB/NewObjectInit.Web/SessionKeepAliveReconnect.aspx.vb))
* [SessionKeepAliveReconnect.aspx.cs](./CS/NewObjectInit.Web/SessionKeepAliveReconnect.aspx.cs) (VB: [SessionKeepAliveReconnect.aspx.vb](./VB/NewObjectInit.Web/SessionKeepAliveReconnect.aspx.vb))
* [Model.xafml](./CS/NewObjectInit.Win/Model.xafml) (VB: [Model.xafml](./VB/NewObjectInit.Win/Model.xafml))
* [Program.cs](./CS/NewObjectInit.Win/Program.cs) (VB: [Program.vb](./VB/NewObjectInit.Win/Program.vb))
<!-- default file list end -->
# How to copy last entered values into a newly created object, when using the Save and New action


<p>This example covers a situation when an end-user fills DetailView information in batch mode. Sometimes it's necessary to duplicate last entered items into a new DetailView form.<br />
For implementation details, please refer to the platform-independent NewValuesController class (see the NewObjectInit.Module project).<br />
Basically, the current object is saved when the Save and New action is executed. After a new DetailView is initialized, the new object is updated using the previous object details.</p>

<br/>


