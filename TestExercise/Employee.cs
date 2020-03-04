using System;

namespace TestExercise
{
    partial class Program
    {
        public class Employee
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }

            public int Pin { get; set; }
        }

#region Not in task scope
        #endregion
    }
}
