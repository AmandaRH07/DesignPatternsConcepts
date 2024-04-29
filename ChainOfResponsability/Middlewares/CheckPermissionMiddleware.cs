namespace ChainOfResponsability.Middlewares
{
    public class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            Console.WriteLine("Seja bem-vindo!");
            return CheckNext(email, password);
        }
    }
}
