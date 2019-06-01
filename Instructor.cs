using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class Instructor {

        public int Id { get; set; }

        public string IFirstName { get; set; }

        public string ILastName { get; set; }

        public string ISlackHandle { get; set; }

        public Cohorts Cohort { get; set; }

        public string Specialty { get; set; }


        // Assign exercises to students
        public void AssignExercise(Student student, Exercises exercise) {
            student.Exercises.Add(exercise);
            exercise.Students.Add(student);
        }

        // ^ Every student has an exercises list, and ever exercise has a students list - join table on the ERD

    }

}