using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_TO_DataSet
{
    class Student
    {
        public int Id;
        public string Name;

        public static DataTable GetObjectStudent(Student[] students)
        {
            DataTable dt = new DataTable();
           
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Name", typeof(string));

            foreach (var item in students)
            {
                dt.Rows.Add(item.Id, item.Name);
            }

            return dt;
        }

        public static void AddEmptyHeader(DataTable db, int strLength)
        {
            string str = string.Format("{0}0,-{1}{2}", "{", strLength, "}");
            Console.WriteLine();
            foreach(DataColumn dc in db.Columns)
            {
                Console.Write(str, dc.ColumnName );
            }
            Console.WriteLine();
            foreach (var item in db.Columns)
            {
                for(int i=0; i<strLength; i++)
                {
                    Console.Write("=");
                }

            }
            Console.WriteLine();
        }
    }
}
