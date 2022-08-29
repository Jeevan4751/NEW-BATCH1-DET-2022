
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_BATCH1_DET_2022
{
    internal class AgeException
    {
        public virtual void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter your age:");
                age = int.Parse(Console.ReadLine());

                if (age < 0 || age > 120)
                {
                    throw new InvalidAgeException("your age looks suspicious   Enter your proper age:");
                }
                else
                    Console.WriteLine("your age is normal:");
            }
            catch (InvalidAgeException X)
            {
                Console.WriteLine(X.Message);
            }
            catch (Exception X)
            { }
        }
    }
}
