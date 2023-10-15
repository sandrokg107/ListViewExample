﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListViewExample
{
    public class Student
    {
        public string Name { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {Name} - {Age}";
            }
        }
        public Student() { }
    }
}