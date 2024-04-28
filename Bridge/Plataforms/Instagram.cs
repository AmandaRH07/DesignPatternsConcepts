namespace Bridge.Plataforms
{
    public class Instagram : IPlatform
    {
        public Instagram()
        {
            ConfigureRMTP();
            Console.WriteLine("Instagram: Transmissão Iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Instagram: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Instagram: Configurando servidor RMTP");
        }
    }
}
