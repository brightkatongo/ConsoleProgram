﻿// // This creates a simple method
using ConsoleProgram.Models;

// // not returning a value

// // define the function
// void Greet(string name){
//     // apply your logic here
//     Console.WriteLine("Hello, "+name); 
// }

// // Call the function
// Greet("Gilbert");

// // This function returns a string
// string GetMessage(string name){
//     string message = "Hello, "+name;

//     return message;
// }

// Console.WriteLine(GetMessage("Peter"));

// ------------Classes--------------------



class Program{
   static void Main(string[] args){
        
        Student studentOne = new Student();

        studentOne.StudentNumber = 1234;
        studentOne.StudentName = "Gilbert";
        studentOne.YearOfStudy = 4;

        Console.WriteLine(studentOne.StudentName);

    }

    // create a method that receives information about yourself and let it print out an aboutme
    // call the method AboutMe

}