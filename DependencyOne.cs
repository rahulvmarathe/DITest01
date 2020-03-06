using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public interface IDependencyOne
    {
        void TestFunc();
    }
    public class DependencyOne : IDependencyOne
    {
        public void TestFunc()
        {
            throw new NotImplementedException();
        }
    }
}
