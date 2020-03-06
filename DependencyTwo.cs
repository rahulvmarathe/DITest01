using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{

    public interface IDependencyTwo
    {
        void TestFunc2();
    }

    public class DependencyTwo : IDependencyTwo
    {
        public void TestFunc2()
        {
            throw new NotImplementedException();
        }
    }
}
