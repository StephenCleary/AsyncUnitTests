Recommended usage: Add (or modify) an `[AssemblyInitialize]` method as below.

    [AssemblyInitialize]
    public static void Initialize(TestContext context)
    {
        StubBehaviors.Current = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();
    }

This sets the default stub behavior to use async-aware default values.