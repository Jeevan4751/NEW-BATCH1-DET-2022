
﻿// See https://aka.ms/new-console-template for more information
using NEW_BATCH1_DET_2022;
using System.Reflection.Metadata.Ecma335;

internal class MyClass 
{
    enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    public static string GetGrade(int mark) //IN parameter
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "PASS";
        else
            return "FAIL";
    }
}
