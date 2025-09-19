namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string EmailAddress { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public Client() : base(0, string.Empty) { }

        public Client(int id, string name, string emailAddress, string password)
            : base(id, name)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
