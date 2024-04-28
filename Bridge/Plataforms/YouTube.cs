namespace Bridge.Plataforms
{
    public class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
