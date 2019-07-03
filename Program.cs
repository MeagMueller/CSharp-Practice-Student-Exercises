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

            Exercises overlyExcited = new Exercises() {
                Id = 4,
                exerciseName = "Overly Excited",
                exerciseLanguage = "Javascript"
            };

            Exercises solarSystem = new Exercises() {
                Id = 5,
                exerciseName = "Solar System",
                exerciseLanguage = "Javascript"
            };

            Exercises carLot = new Exercises() {
                Id = 6,
                exerciseName = "Car Lot",
                exerciseLanguage = "Javascript"
            };

            Exercises dynamicCards = new Exercises() {
                Id = 7,
                exerciseName = "Dynamic Cards",
                exerciseLanguage = "Javascriipt"
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

            // Creating Instructors

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

            Instructor Trelawney = new Instructor() {
                IFirstName = "Sybil",
                ILastName = "Trelawney",
                ISlackHandle = "@SpookyLady",
                Specialty = "Crystal balls"
            };

            Instructor Hagrid = new Instructor() {
                IFirstName = "Rubeus",
                ILastName = "Hagrid",
                ISlackHandle = "@BestBoy",
                Specialty = "Being the most wonderful"
            };

            Instructor Lupin = new Instructor() {
                IFirstName = "Remus",
                ILastName = "Lupin",
                ISlackHandle = "@HowlattheMoon",
                Specialty = "Maybe being a werewolf you don't know"
            };

            Instructor Sprout = new Instructor() {
                IFirstName = "Pomona",
                ILastName = "Sprout",
                ISlackHandle = "@ALittleMugwort",
                Specialty = "p l a n t s  a r e  l i f e"
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

            Cohorts c33 = new Cohorts() {
                Id = 3,
                CohortName = "Still Doesn't Matter Not 31"
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

            List<Student> newStudents = new List<Student> () {
                Luna,
                Neville,
                Fred,
                George
            };

            List<Exercises> newExercises = new List<Exercises> () {
                lists,
                dictionaries,
                classes,
                overlyExcited,
                solarSystem,
                carLot,
                dynamicCards
            };

            List<Instructor> newInstructors = new List<Instructor> () {
                Trelawney, 
                Pomfrey, 
                Sprout, 
                Lupin
            };

            List<Cohorts> newCohorts = new List<Cohorts> () {
                c34,
                c35,
                c36,
                c37
            };

            IEnumerable<string> allJavascriptExercises = from count in newExercises
        }
    }
}
