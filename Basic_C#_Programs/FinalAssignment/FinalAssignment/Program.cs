﻿using FinalAssignment.Data;
using FinalAssignment.Models;
using System;

namespace FinalAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    FirstName = "Anna",
                    LastName = "Smith"
                };
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine("Student added successfully.");
                Console.ReadLine();
            }
        }
    }
}