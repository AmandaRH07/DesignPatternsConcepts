using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    public class Program
    {
        private static Server server;

        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@test.com", "123Abc");
            server.RegisterUser("user@test.com", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            var checkPermissionMiddleware = new CheckPermissionMiddleware();

            middleware.LinkWith(checkPermissionMiddleware);

            server.SetMiddleware(middleware);
        }

        private static void Main(string[] args)
        {
            Init();

            Boolean done = false;
            do
            {
                Console.WriteLine("Digite o seu email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha: ");
                string password = Console.ReadLine();

                done = server.Login(email, password);

            }
            while (!done);

            Console.ReadLine();
        }
    }
}