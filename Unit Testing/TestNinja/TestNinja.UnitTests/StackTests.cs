using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        private Stack<Object> _stack;


        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<Object>();
        }

        [Test]
        public void Push_ObjectIsNull_ReturnArgumentNullException()
        {
            Assert.That(() => _stack.Push(null),
                Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_ObjectIsNotNull_AddsObjectToList()
        {
            //Assert.That(() => _stack.Push("1"), Is);
        }

        [Test]
        public void Pop_ListIsEqualTo0_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(),
                Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_ListIsEqualTo0_ReturnInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(),
                Throws.Exception.TypeOf<InvalidOperationException>());
        }
    }
}
