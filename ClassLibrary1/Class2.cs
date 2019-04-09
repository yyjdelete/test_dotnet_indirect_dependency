using System;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Class2
    {
        public void Test() => Test2();

        private SqlConnection Test2()
        {
            return new ClassLibrary2.Class2().Test();
        }
    }
}
