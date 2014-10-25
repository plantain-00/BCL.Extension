using System;
using System.Collections.Generic;
using System.Data;

namespace BCL.Extension.Example.net35
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //(args.Length == 0).OrThrow();
            //(args.Length != 0).ThenThrow("length equals 0");
            //args.IsNullThenThrow();
            //var time = DateTime.Now.ToInt32();
            //var date = 1403980977.ToDateTime();
            //var datatable = new DataTable();
            //var column1 = new DataColumn
            //              {
            //                  DataType = Type.GetType("System.Int32"),
            //                  ColumnName = "Age"
            //              };
            //datatable.Columns.Add(column1);
            //var column2 = new DataColumn
            //              {
            //                  DataType = Type.GetType("System.String"),
            //                  ColumnName = "Name"
            //              };
            //datatable.Columns.Add(column2);
            //datatable.Rows.Add(1, "a");
            //datatable.Rows.Add(2, "b");
            //var list = datatable.ToList<TestModel>();

            var testModels = new List<TestModel>
                             {
                                 new TestModel
                                 {
                                     Name = "a",
                                     Age = 1
                                 },
                                 new TestModel
                                 {
                                     Name = "b",
                                     Age = 2
                                 }
                             };
            var s = XmlConverter.Serialize(testModels);
            var t = XmlConverter.Deserialize<List<TestModel>>(s);
            Console.Read();
        }
    }
}