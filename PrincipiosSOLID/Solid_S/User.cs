namespace Solid_S
{
    public class User
    {
        // Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        // Constructor
        public User(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
    }
    public class UserDB
    {
        private User _user;
        public UserDB(User user)
        {
            this._user = user;
        }
        public void Save()
        {
            Console.WriteLine($"Guardando. {_user.Name} {_user.LastName}");
        }
    }
    public class SendRequest
    {
        private User _user;

        public SendRequest(User user)
        {
            _user = user;
        }
        public void Send()
        {
            Console.WriteLine($"Enviando a repositorio. {_user.Name} {_user.LastName}");
        }
    }
}