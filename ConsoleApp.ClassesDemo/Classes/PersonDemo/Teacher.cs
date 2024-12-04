﻿using ConsoleApp.ClassesDemo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public class Teacher : Person
    {
        public void GenerateTeacherIdNumber()
        {
            _taxNumber = PersonHelper.GenerateIdNumber("TCH");
        }
    }
}
