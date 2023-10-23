using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public string FullName { get; set; }
        public string Identiti { get; set; }
        public string BirthDate { get; set; }
        public int? City { get; set; }
        public int? Street { get; set; }
        public int? NumderHouse { get; set; }
        public int? Payment { get; set; }
        public int? Budget { get; set; }
        public int? Priority { get; set; }
    }
}
