﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Customer : Person
    {
        public string City { get; set; }
    }



    class Student : Person
    {
        public string TcNo { get; set; }
    }

}




