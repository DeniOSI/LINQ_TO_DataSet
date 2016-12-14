using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_TO_DataSet
{
    class TypeDataSet
    {
        public void WorkWithStudentDataSet()
        {
           StudentDataSet studentDataSet = new StudentDataSet();
            studentDataSet.Students.AddStudentsRow(1, "Denys Osypenko");
            studentDataSet.Students.AddStudentsRow(2, "Tanya Osypenko");
            studentDataSet.Students.AddStudentsRow(3, "Vlada Osypenko");
            studentDataSet.Students.AddStudentsRow(4, "Olexandra Osypenko");
            string name = studentDataSet.Students.Where(k => k.Id == 3).Single().Name;
            Console.WriteLine(name);
        }

       
    }
}
