using System;
using System.Collections.Generic;
using System.Linq;
using courseapp.Models;
using courseapp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace courseapp.Controllers
{
    public class coursecontroller:Controller
    {
       // localhost:5000/course/Index

    [HttpGet]
        public IActionResult Apply()
        {
         
          return View();
        }
    [HttpPost]
        public IActionResult Apply(StudentsResponse students)
        {
            if(ModelState.IsValid==true){
                repository.AddStudent(students);
                return View("Thanks",students);
            }
            else{
                return View(students);
            }
         
        }

        public IActionResult Details()
        {
            var kurs=new Course(){id=1,name=".NET MVC KURSU"};
            var ogrenciler= new List<Student>(){
                new Student(){names="Taha"},
                new Student(){names="Yasin"},
                new Student(){names="Muaz"},
                new Student(){names="Elif"}


            };
            var viewmodel= new CourseStudentViewModel();
            viewmodel.Course=kurs;
            viewmodel.Students=ogrenciler;
            return View(viewmodel);
        }

        public IActionResult List()
        {
            var student=repository.Students.Where(i=>i.confirm==true);
            return View(student);
        }
    }
}
