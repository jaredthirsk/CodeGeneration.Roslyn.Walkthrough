using System;

namespace Walkthrough.Foo
{
    [DuplicateWithSuffix("A")]
    public class Foo
    {
        private void Test()
        {
            var fooA = new FooA();
        }
    }
}
