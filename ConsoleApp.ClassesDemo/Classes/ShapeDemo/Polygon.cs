﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassesDemo
{
    public abstract class Polygon
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract int Area();
    }
}