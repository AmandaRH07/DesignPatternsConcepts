﻿using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability.Servers
{
    public class Server
    {
        private Dictionary<string, string> users = [];
        private Middleware middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean Login(string email, string password)
        {
            if (middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso!");
                Console.WriteLine("Seja bem-vindo!");
                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            string value;
            users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
