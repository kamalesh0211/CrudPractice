﻿using System.ComponentModel.DataAnnotations;

namespace CrudPractice.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName {  get; set; }
        public string Course { get; set; }

    }
}
