using courseapp.Models;
using System.Collections.Generic;


namespace courseapp.ViewModels
{
    public class CourseStudentViewModel
    {
        public Course Course{get;set;}
        public List<Student> Students{get;set;}
    }
}