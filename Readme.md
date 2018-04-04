Issue - Cannot use Structuremap in the traditional sense in the ADS because Worker.Process calls static Run Methods and Processors inherit from an Abstract Class.

Look at:

* TheGreenOneWorker.Services.ServiceRegistry.cs

* TheGreenOneWorker.ConsoleApp.DefaultRegistry.cs

* TheGreenOneWorker.ConsoleApp.IoC.cs

* TheGreenOneWorker.ConsoleApp.Program.cs

* TheGreenOneWorker.Services.BaseProcessor Changes:
	* Add static IContainer Property
	* Add abstract GetProcessorType Method
	* Modify Start Method to get the TProcessorType and pull the processor via the IContainer by object type name
	
	
Note: Created 2 basic Repositories and using Setter Injection inside the Processors to initialize classes.