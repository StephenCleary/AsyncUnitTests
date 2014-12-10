![logo](https://github.com/StephenCleary/AsyncUnitTests/raw/master/AsyncExUnitTests.128.png)

Async-Aware Default Stub Behavior for Microsoft Fakes
===

The built-in default stub behavior for Microsoft Fakes will return `null` tasks from asynchronous methods. The [Nito.AsyncEx.UnitTests.MSFakes NuGet package](https://www.nuget.org/packages/Nito.AsyncEx.UnitTests.MSFakes/) provides the `AsyncAwareDefaultValueStubBehavior` type.

Recommended usage is to apply the async-aware default stub behavior to all unit tests in a project:

````C#
[AssemblyInitialize]
public static void Initialize(TestContext context)
{
  StubBehaviors.Current = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();
}
````

However, it can be set on a test-by-test basis:

````C#
var stub = new Stub...;
stub.InstanceBehavior = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();
````