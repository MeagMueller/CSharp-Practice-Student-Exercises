using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class Exercises {

        public int Id { get; set; }

        public string exerciseName { get; set; }

        public string exerciseLanguage { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

    }
}