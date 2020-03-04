using System;
using System.Collections.Generic;
using System.Linq;

namespace TestExercise
{
    partial class Program
    {
        #region Not in task scope
        public class EmployeeGenerator
        {
            Random random = new Random();
            public IEnumerable<Employee> GetEmployees(int count = 100)
            {
                return Enumerable.Range(0, count).Select((r, i) => this.GetEmployee(i + 1));
            }

            private Employee GetEmployee(int pin)
            {
                return new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = this.GetName(this.FirstNames),
                    SecondName = this.GetName(this.SecondNames),
                    Pin = pin
                };
            }

            private string GetName(string[] names)
            {
                var max = names.Length;
                var position = this.random.Next(0, max);
                return names[position];
            }

            private string[] FirstNames = new string[] {
                "Pavel", "Vasya", "Petya", "Katya", "Lena",
                "Julia", "Kostya", "Oleg", "Igor", "Elena",
                "Anna", "Oksana", "Sigizmund", "Ozimandia", "Ursula",
                "James","John","Robert","Michael","William","David",
                "Richard","Joseph","Thomas","Charles","Christopher",
                "Daniel","Matthew","Anthony","Donald","Mark","Paul",
                "Steven","Andrew","Kenneth","Joshua","George","Kevin",
                "Brian","Edward","Ronald","Timothy","Jason","Jeffrey",
                "Ryan","Jacob","Gary","Nicholas","Eric","Stephen",
                "Jonathan","Larry","Justin","Scott","Brandon","Frank",
                "Benjamin","Gregory","Samuel","Raymond","Patrick",
                "Alexander","Jack","Dennis","Jerry","Tyler","Aaron",
                "Jose","Henry","Douglas","Adam","Peter","Nathan",
                "Zachary","Walter","Kyle","Harold","Carl","Jeremy",
                "Keith","Roger","Gerald","Ethan","Arthur","Terry",
                "Christian","Sean","Lawrence","Austin","Joe","Noah",
                "Jesse","Albert","Bryan","Billy","Bruce","Willie",
                "Jordan","Dylan","Alan","Ralph","Gabriel","Roy",
                "Juan","Wayne","Eugene","Logan","Randy","Louis",
                "Russell","Vincent","Philip","Bobby","Johnny","Bradley",
                "Mary","Patricia","Jennifer","Linda","Elizabeth",
                "Barbara","Susan","Jessica","Sarah","Karen","Nancy",
                "Margaret","Lisa","Betty","Dorothy","Sandra","Ashley",
                "Kimberly","Donna","Emily","Michelle","Carol","Amanda",
                "Melissa","Deborah","Stephanie","Rebecca","Laura","Sharon",
                "Cynthia","Kathleen","Helen","Amy","Shirley","Angela",
                "Anna","Brenda","Pamela","Nicole","Ruth","Katherine",
                "Samantha","Christine","Emma","Catherine","Debra",
                "Virginia","Rachel","Carolyn","Janet","Maria","Heather",
                "Diane","Julie","Joyce","Victoria","Kelly","Christina",
                "Joan","Evelyn","Lauren","Judith","Olivia","Frances",
                "Martha","Cheryl","Megan","Andrea","Hannah","Jacqueline",
                "Ann","Jean","Alice","Kathryn","Gloria","Teresa","Doris",
                "Sara","Janice","Julia","Marie","Madison","Grace","Judy",
                "Theresa","Beverly","Denise","Marilyn","Amber","Danielle",
                "Abigail","Brittany","Rose","Diana","Natalie",
                "Sophia","Alexis","Lori","Kayla","Jane"
            };
            private string[] SecondNames = new string[] {
                "Zoloto", "Serebro", "Oksenko", "Poloniy", "Uranium",
                "Argentum", "Selen", "Mercurio", "Black", "White",
                "Argon", "Klaz", "Hamurapi", "R2D2", "Green", "Smith",
                "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller",
                "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson",
                "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez",
                "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker",
                "Hall", "Allen", "Young", "Hernandez", "King", "Wright",
                "Lopez", "Hill", "Scott", "Green", "Adams", "Baker",
                "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez",
                "Roberts", "Turner", "Phillips", "Campbell", "Parker",
                "Evans", "Edwards", "Collins", "Stewart", "Sanchez",
                "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell",
                "Murphy", "Bailey", "Rivera", "Cooper", "Richardson",
                "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray",
                "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders",
                "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson",
                "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson",
                "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster",
                "Gonzales", "Bryant", "Alexander", "Russell", "Griffin",
                "Diaz", "Hayes"
            };
        }
        #endregion
    }
}
