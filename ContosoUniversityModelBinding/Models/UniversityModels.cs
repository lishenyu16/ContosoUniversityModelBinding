﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoUniversityModelBinding.Models
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }

    public class Student
    {
        [Key, Display(Name = "ID")]
        [ScaffoldColumn(false)]
        public int StudentID { get; set; }

        [Required, StringLength(50), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(50), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Range(typeof(DateTime), "1/1/2023", "1/1/2100", ErrorMessage = "Please provide an enrollment date after 1/1/2023")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EnrollmentDate { get; set; }

        [EnumDataType(typeof(AcademicYear)), Display(Name = "Academic Year")]
        public AcademicYear Year { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }

    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public enum AcademicYear
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
}