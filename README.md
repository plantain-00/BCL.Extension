BCL.Extension
=============

Extension to types from Basic Class Library.
## Exception
    (args.Length == 0).OrThrow();
	(args.Length != 0).ThenThrow("length equals 0");
    args.Length.IsNullThenThrow();
## DateTime
    DateTime.Now.ToInt32();//1403980977
	var date = 1403980977.ToDateTime();//2014/6/28 ÐÇÆÚÁù 18:42:57
## DateTable
    public class TestModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

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

You can get [it](https://www.nuget.org/packages/BCL.Extension) from Nuget.
