using System.Collections.Generic;

namespace SF_12_1_5
{
    class Users
    {
        /// <summary>
        /// Список пользователей.
        /// </summary>
        private List<User> users = new List<User>();

        /// <summary>
        /// Инициализирует список пользователей.
        /// </summary>
        public Users()
        {
            users.Add(new User { Login = "Egor", Name = "Егор", IsPremium = true });
            users.Add(new User { Login = "Petr", Name = "Пётр", IsPremium = false });
            users.Add(new User { Login = "Vitaliy", Name = "Виталий", IsPremium = false });
            users.Add(new User { Login = "Elena", Name = "Елена", IsPremium = true });
            users.Add(new User { Login = "Oksana", Name = "Оксана", IsPremium = false });
        }

        /// <summary>
        /// Возвращает список пользователей.
        /// </summary>
        /// <returns></returns>
        public List<User> GetListUsers()
        {
            return users;
        }
    }
}