using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_TO_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1, stud2;
            GetStudArr(out stud1, out stud2);
            DataTable dtForHeader = Student.GetObjectStudent(stud1);
           
            IEnumerable < DataRow > dt1 = Student.GetObjectStudent(stud1).AsEnumerable();
           
            IEnumerable < DataRow > dt2 = Student.GetObjectStudent(stud2).AsEnumerable();


            #region SetField
            //(from dttt in dt1 where dttt.Field<string>("Name") == "Denis Osipenko" select dttt).Single<DataRow>().SetField(("Name"), "Dmitry Borzow");
            //foreach (DataRow r in dt1)
            //{
            //    Console.WriteLine(r.Field<int>("Id") + r.Field<string>("Name"));
            //}
            //DataTable copyToDataTable = new DataTable();

            //Console.WriteLine(Environment.NewLine);
            //copyToDataTable = dt1.CopyToDataTable();
            //copyToDataTable.PrimaryKey = new DataColumn[]{copyToDataTable.Columns[0]};
            //foreach (DataRow r in copyToDataTable.Rows)
            //{
            //    Console.WriteLine(r.Field<int>("Id") + r.Field<string>("Name"));
            //}
            #endregion

            #region Intersect
            //Console.WriteLine("-----Intersect-------);
            // var intersectStudents = dt1.Intersect(dt2, System.Data.DataRowComparer.Default); 
            #endregion

            #region Union
            //Console.WriteLine("-------Union-----------");
            //var intersectStudents = dt1.Union(dt2, System.Data.DataRowComparer.Default); 
            #endregion

            #region SequenceEquals
            //bool sequenceEquals = dt1.SequenceEqual(dt2, System.Data.DataRowComparer.Default);
            //var sequanceEqualsB = dt1.SequenceEqual(dt1, System.Data.DataRowComparer.Default);
            //Console.WriteLine("first defination - {0}, second defination - {1}", sequenceEquals, sequanceEqualsB);
            #endregion


            #region PrintResult
            //Student.AddEmptyHeader(dtForHeader, 15);
            //foreach (DataRow dataRow in intersectStudents)
            //{
            //    Console.WriteLine("{0,-15}{1,-15}", dataRow.Field<int>("Id"), dataRow.Field<string>("Name"));
            //} 
            #endregion


            #region DataSet
            TypeDataSet tds = new TypeDataSet();
            tds.WorkWithStudentDataSet();
            #endregion

        }

        private static void GetStudArr(out Student[] students1, out Student[] students2)
        {

           Student[] stud1 = {
                new Student { Id = 1, Name = "Denis Osipenko" },
                new Student { Id = 2, Name = "Ivan Petrov" },

              //  new Student { Id = 2, Name = "Ivan Petrov" },
                new Student { Id = 5, Name = "Oleksandr Petrov" },
                new Student { Id = 6, Name = "Natalya Ivanova" },
                new Student { Id = 7, Name = "Ivanna Tubichko" }
            };
           Student[] stud2 = {
                new Student { Id = 1, Name = "Denis Osipenko" },

                new Student { Id = 5, Name = "Oleksandr Petrov" },
                new Student { Id = 6, Name = "Natalya Ivanova" },
                new Student { Id = 7, Name = "Ivanna Tubichko" }
            };
            students1 = stud1;
            students2 = stud2;
        }
    }
}
