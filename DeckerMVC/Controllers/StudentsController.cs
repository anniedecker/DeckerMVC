using DeckerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeckerMVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            Student s1 = new Student()
            {
                StudentID = 111,
                FirstName = "Annie",
                LastName = "Decker",
                FavoriteColor = "Gray"
            };

            Student s2 = new Student()
            {
                StudentID = 2,
                FirstName = "Katherine",
                LastName = "Harris",
                FavoriteColor = "Blue"
            };

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            return View(students);
        }

       
        
        
    }
}
