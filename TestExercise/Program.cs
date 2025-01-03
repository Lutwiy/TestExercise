﻿using System;
using System.Linq;

using TestExercise.Generator;

namespace TestExercise
{
    partial class Program
    {
        // In our system, many users are trying to access.
        // Each user is assigned a Token by an external identification service.
        // Our task is to process this token and display an error message according to the business rule.
        //
        // The business requires:
        // * For each user whose token is divisible by 7 without a remainder, display 'Temporary Ban' next to their token.
        // * If the token is divisible by 3 without a remainder, display 'Had Warnings'.
        // * If the token is divisible by both 3 and 7 without a remainder, display 'Permanent Banned'.
        // * Users whose token is not divisible by any of these numbers should not be displayed.
        static void Main(string[] args)
        {
            var users = new ExternalIdentityService().GetUsers().ToList();
            users.ForEach(us => Console.WriteLine($"Token: {us.Token}. User: {us.FirstName} {us.SecondName}."));
        }
    }
}
