using System;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Domain
{
    public class Student : Person, ILearner, IBikeRider
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public string StudentId { get; set; }
        public string Passport { get; set; }

        public Student(string firstName, string lastName, double height, double weight, string studentId, string passport)
            : base(firstName, lastName)
        {
            Height = height;
            Weight = weight;
            StudentId = studentId;
            Passport = passport;
        }

        public bool HasIdealWeight() => Math.Abs(Height - 110 - Weight) < 0.001;

        public void Study() { }
        public void RideBike() { }

        public override string Serialize()
        {
            return $"Student {FirstName}{LastName}\n{{\n" +
                   $"  \"firstname\": \"{FirstName}\",\n" +
                   $"  \"lastname\": \"{LastName}\",\n" +
                   $"  \"height\": \"{Height}\",\n" +
                   $"  \"weight\": \"{Weight}\",\n" +
                   $"  \"studentId\": \"{StudentId}\",\n" +
                   $"  \"passport\": \"{Passport}\"\n}};\n";
        }
    }
}