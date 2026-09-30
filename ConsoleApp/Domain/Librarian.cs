using ConsoleApp.Interfaces;

namespace ConsoleApp.Domain
{
    public class Librarian : Person, IBikeRider
    {
        public string LibraryId { get; set; }

        public Librarian(string firstName, string lastName, string libraryId)
            : base(firstName, lastName)
        {
            LibraryId = libraryId;
        }

        public void RideBike()
        {
            
        }

        public override string Serialize()
        {
            return $"Librarian {FirstName}{LastName}\n{{\n" +
                   $"  \"firstname\": \"{FirstName}\",\n" +
                   $"  \"lastname\": \"{LastName}\",\n" +
                   $"  \"libraryId\": \"{LibraryId}\"\n}};\n";
        }
    }
}