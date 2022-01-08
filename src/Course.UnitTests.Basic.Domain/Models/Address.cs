namespace Course.UnitTests.Basic.Domain.Models
{
    public class Address
    {
        public Address(string morada, string number, string location, string complement, string document)
        {
            Morada = morada;
            Number = number;
            Location = location;
            Complement = complement;
            Document = document;
        }

        public string Morada { get; private set; }
        public string Number { get; private set; }
        public string Location { get; private set; }
        public string Complement { get; private set; }
        public string Document { get; private set; }
    }
}
