﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        public string Firstname;
        public string Lastname;

       public string GetFullname()
         {   
           
            return this.Lastname + " " + this.Firstname;
         }

    }
}
