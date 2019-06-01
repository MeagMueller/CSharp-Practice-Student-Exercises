using System;
using System.Collections.Generic;

namespace StudentExercises {

    public class Student {

        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string SlackHandle { get; set; }

        public Cohorts Cohort { get; set; }

        public List<Exercises> Exercises { get; set; } = new List<Exercises>();

    }

}