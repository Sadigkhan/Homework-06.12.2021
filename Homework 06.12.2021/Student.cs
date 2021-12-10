using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06._12._2021
{
    internal class Student
    {
        string Fullname;
        int Course;
        string Subject;
        string University;
        string Email;
        double PhoneNumber;
        public Student(string fullname,int course,string subject,string university,string email,double phoneNumber)
        {
            Fullname = fullname;
            Course = course;   
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public string Info()
        {
            return $"{Fullname}{Course}{Subject}{University}{Email}{PhoneNumber}";
        }
       
        
    }
}
