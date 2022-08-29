using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    /// <summary>
    /// derived class from emp
    /// </summary>
    public class Manager:Emp
    {
        public string Project { get; set; }
        public int Teamsize { get; set; }
        /// <summary>
        /// calling base class constructor from derived class 'base' keyword
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="doj"></param>
        /// <param name="project"></param>
        /// <param name="teamsize"></param>
        public Manager(int id, string name, DateTime doj, string project, int teamsize):base(id,name,doj)
        {
            this.Project = project;
            Teamsize = teamsize;    
        }

       override public  string ToString()
        { 
        return $"Emp Details={base.ToString()}, Project={Project},Teamsize={Teamsize}";
        }
    }
}
