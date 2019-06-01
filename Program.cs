using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating exercises

            Exercises lists = new Exercises() {
                Id = 1, 
                exerciseName = "Lists", 
                exerciseLanguage = "C#"
            };

            Exercises dictionaries = new Exercises() {
                Id = 2, 
                exerciseName = "Dictionaries",
                exerciseLanguage = "C#"
            };

            Exercises classes = new Exercises() {
                Id = 3, 
                exerciseName = "Classes",
                exerciseLanguage = "C#"
            };

            // Creating students

            Student Ronald = new Student() {
                firstName = "Ronald",
                lastName = "Weasley",
                SlackHandle = "@Ginger21"
            };

            Student Harry = new Student() {
                firstName = "Harry",
                lastName = "Potter",
                SlackHandle = "@TheBoyWhoLived"
            };

            Student Hermione = new Student() {
                firstName = "Hermione",
                lastName = "Granger",
                SlackHandle = "@Ravenclaw"
            };

            Instructor McGonagall = new Instructor() {
                IFirstName = "Minerva",
                ILastName = "McGonagall",
                ISlackHandle = "@McGonagall",
                Specialty = "Badassery"
            };

            Instructor Dumbledore = new Instructor() {
                IFirstName = "Albus",
                ILastName = "Dumbledore",
                ISlackHandle = "@10PointstoGryffindor",
                Specialty = "Silly hats"
            };

            Instructor Snape = new Instructor() {
                IFirstName = "Severus",
                ILastName = "Snape",
                ISlackHandle = "@ILoveLily5Ever",
                Specialty = "Lying"
            };

            // When a new cohort is created, it's a new list

            Cohorts c31 = new Cohorts() {
                Id = 1,
                CohortName = "Cohort 31"
            };

            Cohorts c32 = new Cohorts() {
                Id = 2, 
                CohortName = "Doesn't Matter Not 31"
            };


            // Defining both sides of the one to many relationships

                // Instructors

            c31.Instructors.Add(McGonagall);
            McGonagall.Cohort = c31; 

            c31.Instructors.Add(Dumbledore);
            Dumbledore.Cohort = c31;

            c32.Instructors.Add(Dumbledore);
            Dumbledore.Cohort = c32;

            c31.Instructors.Add(Snape);
            Snape.Cohort = c31;

                // Students

            c31.Students.Add(Ronald);
            Ronald.Cohort = c31;

            c31.Students.Add(Harry);
            Harry.Cohort = c31;

            c31.Students.Add(Hermione);
            Hermione.Cohort = c31;

            // Calling assigning exercises method

            McGonagall.AssignExercise(Ronald, lists);
            McGonagall.AssignExercise(Ronald, dictionaries);

            Dumbledore.AssignExercise(Harry, classes);
            Dumbledore.AssignExercise(Hermione, lists);
            Dumbledore.AssignExercise(Hermione, dictionaries);
            Dumbledore.AssignExercise(Hermione, classes);


            Console.WriteLine("Ronald's Exercises");

            // Iterating over 

            foreach(Exercises exercise in Ronald.Exercises) {
                Console.WriteLine(exercise.exerciseName);
            }

            Console.WriteLine();

            Console.WriteLine("Harry's Exercises");

            foreach(Exercises exercise in Harry.Exercises) {
                Console.WriteLine(exercise.exerciseName);
            }

            Console.WriteLine();

            Console.WriteLine("Hermione's Exercises");

            foreach(Exercises exercise in Hermione.Exercises) {
                Console.WriteLine(exercise.exerciseName);
            }

            Console.WriteLine();

            Console.WriteLine("Who Has the Thing?");

            foreach(Student student in lists.Students) {
                Console.WriteLine(student.firstName);
            }
        }
    }
}
