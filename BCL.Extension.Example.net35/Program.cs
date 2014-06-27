using System;
using System.Data;

namespace BCL.Extension.Example.net35
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (args.Length == 0).OrThrow();
            args.Length.IsNullThenThrow();
            var time = DateTime.Now.ToInt32();
            var datatable = new DataTable();
            var column1 = new DataColumn
                          {
                              DataType = Type.GetType("System.Int32"),
                              ColumnName = "Age"
                          };
            datatable.Columns.Add(column1);
            var column2 = new DataColumn
                          {
                              DataType = Type.GetType("System.String"),
                              ColumnName = "Name"
                          };
            datatable.Columns.Add(column2);
            datatable.Rows.Add(1, "a");
            datatable.Rows.Add(2, "b");
            var list = datatable.ToList<TestModel>();
        }
    }
}