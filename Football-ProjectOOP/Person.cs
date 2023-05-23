﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Football_ProjectOOP
{
    public abstract class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
