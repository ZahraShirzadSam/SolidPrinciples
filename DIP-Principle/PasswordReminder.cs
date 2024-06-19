
namespace DIP_Principle
{
    public class PasswordReminder
    {
        private MySQLConnection dbConnection;
        public PasswordReminder(MySQLConnection connection)
        {
            dbConnection = connection;
        }
    }
}
