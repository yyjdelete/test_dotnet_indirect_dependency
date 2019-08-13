using System;
using System.Data.SqlClient;

namespace ClassLibrary1
{
    public class Class2
    {
        public void Test() => Test2();

        public SqlConnection Test2()
        {
            return new SqlConnection();
        }

        public void Test3()
        {
            new ClassLibrary2.Class2().Test();
        }
    }
}
