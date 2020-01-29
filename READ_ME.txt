Hi Andrew,

Check this out. I did it last night, with extensive use of docs.microsoft.com and stackexchange. See what you think. I am including scripts to 
generate and seed the database that runs on sqlserver. Let me know if you need any other db format. I am using Moq to mimic another data
repo. Put a breakpoint at line 32 in Program.cs then examine the value in var result. It should say "No stuff" based the flow control in the
Index() method in ThingsController.cs. Then let it run and it should show you the \Views\Things\Things.cshtml.

As you can see, the data source is being injected into the constructor for ThingsController.cs. As long as it's of type IRecordRepo it's good
to go. I am using ef for sqlserver, and Moq lets you mock up a data source of any type <T>. 