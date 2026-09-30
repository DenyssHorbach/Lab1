using ConsoleApp.Interfaces;

namespace ConsoleApp.Domain
{
    public class SoftwareDeveloper : Person, ILearner, IBikeRider
    {
        public string MainLanguage { get; set; }

        public SoftwareDeveloper(string firstName, string lastName, string mainLanguage)
            : base(firstName, lastName)
        {
            MainLanguage = mainLanguage;
        }

        public void Study()
        {
            
        }

        public void RideBike()
        {

        }

        public override string Serialize()
        {
            return $"SoftwareDeveloper {FirstName}{LastName}\n{{\n" +
                   $"  \"firstname\": \"{FirstName}\",\n" +
                   $"  \"lastname\": \"{LastName}\",\n" +
                   $"  \"mainLanguage\": \"{MainLanguage}\"\n}};\n";
        }
    }
}