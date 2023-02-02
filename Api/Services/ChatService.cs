using System.Collections.Generic;

namespace Api.Services
{
    public class ChatService
    {
        // Key , Value eg: { {"john", "asdsah!@12321"}, {"david", "ajsdhsaj2312"}}
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>();

        public bool AddUserToList(string userToAdd)
        {
            lock(Users)
            {
                foreach(var user in Users)
                {
                    if(user.Key.ToLower() == userToAdd.ToLower())
                    {
                        return false;
                    }
                }
                Users.Add(userToAdd, null);
                return true;
            }

        }
    }
}
