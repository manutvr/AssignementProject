﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignementProject.Utility
{
    public class DataSource
    {
        public static object[] ValidLoginTest()

        {


            object[] dataset1 = new object[3];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "Quick Launch";
            //object[] dataset2 = new object[3];
            //dataset2[0] = "physician";
            //dataset2[1] = "physician";
            //dataset2[2] = "OpenEMR";
            Object[] allData = new object[1];
            allData[0] = dataset1;
           // allData[1] = dataset2;
            return allData;

        }
        public static object[] InValidLoginTest()
        {
            object[] dataset1 = new object[3];
            dataset1[0] = "John";
            dataset1[1] = "admin123";
            dataset1[2] = "Invalid credentials";
            object[] dataset2 = new object[3];
            dataset2[0] = "Saul";
            dataset2[1] = "Saul123";
            dataset2[2] = "Invalid credentials";

            object[] dataset3 = new object[3];
            dataset3[0] = "peter";
            dataset3[1] = "peter123";
            dataset3[2] = "Invalid credentials";


            Object[] allData = new object[3];
            allData[0] = dataset1;
            allData[1] = dataset2;
            allData[2] = dataset3;
            return allData;
        }

    }
}
