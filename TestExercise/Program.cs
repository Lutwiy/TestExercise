using System;
using System.Linq;
using TestExercise.Generator;

namespace TestExercise
{
    partial class Program
    {
        /// Задача
        /// Я, как пользователь, хочу,
        ///  * чтобы каждый сотрудник, чей Пин делиться без остатка на 7, то рядом с его пином должно быть слово WithBonus,
        ///  * если делиться на 3 Fired,
        ///  * а если делиться без остатка и на 3 и на 7, то должно выводиться только слово FiredWithBonus.
        static void Main(string[] args)
        {
            var employees = new EmployeeGenerator().GetEmployees().ToList();
            employees.ForEach(r => Console.WriteLine($"Pin {r.Pin} {r.FirstName} {r.SecondName}"));
        }
    }
}
