using System;
using System.Threading.Tasks;
using Microsoft.QualityTools.Testing.Fakes.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nito.AsyncEx.UnitTests.MSFakes;
using Sut;
using Sut.Fakes;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTests
    {
        //[AssemblyInitialize]
        //public static void Initialize(TestContext context)
        //{
        //    StubBehaviors.Current = new Nito.Async.UnitTests.AsyncAwareDefaultValueStubBehavior();
        //}
        
        [TestMethod]
        public void DefaultStubBehavior_TaskReturnType_ReturnsNullTask()
        {
            var stub = new StubIService() as IService;
            var task = stub.ReturnNothingAsync();
            Assert.IsNull(task);
        }

        [TestMethod]
        public void AsyncStubBehavior_TaskReturnType_ReturnsCompletedTask()
        {
            var stub = new StubIService { InstanceBehavior = new AsyncAwareDefaultValueStubBehavior() } as IService;
            var task = stub.ReturnNothingAsync();
            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsCompleted && !task.IsFaulted && !task.IsCanceled);
        }

        [TestMethod]
        public void DefaultStubBehavior_TaskOfIntReturnType_ReturnsNullTask()
        {
            var stub = new StubIService() as IService;
            var task = stub.ReturnIntAsync();
            Assert.IsNull(task);
        }

        [TestMethod]
        public void AsyncStubBehavior_TaskOfIntReturnType_ReturnsCompletedTask()
        {
            var stub = new StubIService { InstanceBehavior = new AsyncAwareDefaultValueStubBehavior() } as IService;
            var task = stub.ReturnIntAsync();
            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsCompleted && !task.IsFaulted && !task.IsCanceled);
            Assert.AreEqual(0, task.Result);
        }

        [TestMethod]
        public void DefaultStubBehavior_TaskOfBoolReturnType_ReturnsNullTask()
        {
            var stub = new StubIService() as IService;
            var task = stub.ReturnBoolAsync();
            Assert.IsNull(task);
        }

        [TestMethod]
        public void AsyncStubBehavior_TaskOfBoolReturnType_ReturnsCompletedTask()
        {
            var stub = new StubIService { InstanceBehavior = new AsyncAwareDefaultValueStubBehavior() } as IService;
            var task = stub.ReturnBoolAsync();
            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsCompleted && !task.IsFaulted && !task.IsCanceled);
            Assert.AreEqual(false, task.Result);
        }

        [TestMethod]
        public void DefaultStubBehavior_TaskOfObjectReturnType_ReturnsNullTask()
        {
            var stub = new StubIService() as IService;
            var task = stub.ReturnObjectAsync();
            Assert.IsNull(task);
        }

        [TestMethod]
        public void AsyncStubBehavior_TaskOfObjectReturnType_ReturnsCompletedTask()
        {
            var stub = new StubIService { InstanceBehavior = new AsyncAwareDefaultValueStubBehavior() } as IService;
            var task = stub.ReturnObjectAsync();
            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsCompleted && !task.IsFaulted && !task.IsCanceled);
            Assert.IsNull(task.Result);
        }

        [TestMethod]
        public void DefaultStubBehavior_TaskOfTaskOfIntReturnType_ReturnsNullTask()
        {
            var stub = new StubIService() as IService;
            var task = stub.ReturnTaskOfIntAsync();
            Assert.IsNull(task);
        }

        [TestMethod]
        public void AsyncStubBehavior_TaskOfTaskOfIntReturnType_ReturnsCompletedTasks()
        {
            var stub = new StubIService { InstanceBehavior = new AsyncAwareDefaultValueStubBehavior() } as IService;
            var task = stub.ReturnTaskOfIntAsync();
            Assert.IsNotNull(task);
            Assert.IsTrue(task.IsCompleted && !task.IsFaulted && !task.IsCanceled);
            var innerTask = task.Result;
            Assert.IsNotNull(innerTask);
            Assert.IsTrue(innerTask.IsCompleted && !innerTask.IsFaulted && !innerTask.IsCanceled);
            Assert.AreEqual(0, innerTask.Result);
        }
    }
}
