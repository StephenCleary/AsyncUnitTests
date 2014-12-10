To apply to all tests by default:
=================================

Add (or modify) an [AssemblyInitialize] method as below.

    [AssemblyInitialize]
    public static void Initialize(TestContext context)
    {
        StubBehaviors.Current = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();
    }

This sets the default stub behavior to use async-aware default values.


To apply to a single test:
==========================

Set the stub's InstanceBehavior property as below.

    var stub = new Stub...;
    stub.InstanceBehavior = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();