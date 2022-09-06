using NEW_BATCH1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections;
using System.Data.SqlClient;



namespace NEW_BATCH1_DET_2022
{
    internal class DatabaseFristApproach
    {
        static void Main(string[] args)
        {
            //  GetAllEmpDetails();
            // GetEmpDetailsByID();
            //AddNewEmployee();
            DeleteEmployee();
             //UpdateEmployee();
           // SPWithoutParameter();
            //SPWithParameter();
           // SPInsert();
            Console.ReadLine();
        }

        private static void AddNewEmployee()
        {

            var ctx = new tsql_trainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2979;
                employee.Ename = "sheela";
                employee.Sal = 100000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("Added succesfully");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            /* var ctx = new tsql_trainingContext();
             var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
             Console.WriteLine(emp.Ename+"   "+emp.Sal+"  "+emp.Job  );*/
        }
        private static void DeleteEmployee()
        {


            var ctx = new tsql_trainingContext();

            try
            {
                Emp employee = new Emp();
                employee.Empno = 2979;
                employee.Ename = "sheela";
                employee.Sal = 100000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("Added succesfully");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       /*private static void UpdateEmployee()
            {

                var ctx = new tsql_trainingContext();

                try
                {
                    Emp employee = new Emp();
                    employee.Empno = 7369;
                    employee.Ename = "SHIVA";
                employee.Sal = 28850;
                employee.Deptno = 30;
                employee.Job = "MANAGER";
                ctx.Update(employee);
                    ctx.SaveChanges();
                    Console.WriteLine("Updated succesfully");

                }

                catch (Exception ex)
                {
                Console.WriteLine(ex.InnerException.Message);
                }


            }
       */

        private static void SPWithoutParameter()
        {
            var ctx = new tsql_trainingContext();
            var employee = ctx.Emps.FromSqlRaw("spgetemployee").ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Empno);
            }
        }

        private static void SPWithParameter()
        {
            var ctx = new tsql_trainingContext();

            var employee = ctx.Emps.FromSqlRaw("spGetEmployeeByENAME @p0", 7788).ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
        }
       
        /*private static void SPInsert()


        {
            var ctx = new tsql_trainingContext(); 
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2277},


                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Bharat"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Trainer"},

                          new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30000},

                           new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30 }

                           };
            try
            {

                var result = ctx.Database.ExecuteSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                //var result = ctx.Database.ExecuteSqlCommand("AddNewBook @id, @name, @price", param);
                //// var result = ctx.Emps.FromSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);
                //var result =ctx.Database.ExecuteSqlCommand("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                ctx.SaveChanges();
                Console.WriteLine("inserted");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");
        }*/
    }
}