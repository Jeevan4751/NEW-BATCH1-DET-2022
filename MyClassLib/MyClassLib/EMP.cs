namespace MyClassLib;



    public class EMP
    {
        int id;
        string name;
        string dept;
        double sal;
        


     public DateTime doj { get; set; }
        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public EMP(int eid, string ename, DateTime doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }
    }
