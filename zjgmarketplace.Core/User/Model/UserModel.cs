namespace zjgmarketplace.Core.User.Model
{
    public class UserModel
    {
        private readonly string _id;
        private readonly string _name;
        private readonly string _email;
        private readonly string _password;
        private readonly string _phone;

        private UserModel()
        {
            _id = Guid.NewGuid().ToString();
        }

        private UserModel(string id, string name, string email, string password, string phone)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _phone = phone;
        }

        public static UserModel Instanciate(string id, string name, string email, string password, string phone)
        {
            return new UserModel(id,
                                 name,
                                 email,
                                 password,
                                 phone);
        }
    }
}
