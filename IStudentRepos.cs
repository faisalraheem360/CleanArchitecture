﻿using CleanARCHiLMS_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanARCHiLMS_Application
{
    public interface IStudentRepos
    {
        Student GetStudentByID(int ID);
        List<Student> GetAllStudents();
        Student CreateStudent(Student student);
        Student DeleteStudent(int id);
        Student SaveStudent(Student student);
        Student UpdateStudent(Student student);
      
    }
}
