using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    public class LINQ_Employee
    {
        



            public LINQ_Employee(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }

        private static List<LINQ_Employee> GetListofEmployees()
        {
            List<LINQ_Employee> emps = new List<LINQ_Employee>();
            emps.Add(new LINQ_Employee(1, "John", "Training"));
            emps.Add(new LINQ_Employee(2, "Mark", "Finance"));
            emps.Add(new LINQ_Employee(3, "Peter", "Technical"));
            emps.Add(new LINQ_Employee(4, "Bob", "Technical"));
            emps.Add(new LINQ_Employee(5, "Robert", "Finance"));
            emps.Add(new LINQ_Employee(6, "Jason", "Training"));

            return emps;
        }
    }

    
}