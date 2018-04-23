# How to copy last entered values into a newly created object, when using the Save and New action


<p>This example covers a situation when an end-user fills DetailView information in batch mode. Sometimes it's necessary to duplicate last entered items into a new DetailView form.<br />
For implementation details, please refer to the platform-independent NewValuesController class (see the NewObjectInit.Module project).<br />
Basically, the current object is saved when the Save and New action is executed. After a new DetailView is initialized, the new object is updated using the previous object details.</p>

<br/>


