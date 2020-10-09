using System;
using System.Linq;
using TestExercise.Generator;

namespace TestExercise
{
    partial class Program
    {
        //  Я, как пользователь, хочу,
        //  * чтобы рядом с пином каждого сотрудника, чей Пин делиться без остатка на 7, отображалось слово WithBonus,
        //  * если делиться на 3 - Fired,
        //  * а если делиться без остатка и на 3 и на 7, то должно выводиться только слово FiredWithBonus.
        //  * сотрудники, чей пин не делиться ни на одно из этих чисел - выводиться не должны.
        static void Main(string[] args)
        {
            var employees = new EmployeeGenerator().GetEmployees().ToList();
            employees.ForEach(r => Console.WriteLine($"Pin {r.Pin} {r.FirstName} {r.SecondName}"));
        }
    }
}
