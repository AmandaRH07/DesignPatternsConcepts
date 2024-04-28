using Bridge.Plataforms;

namespace Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform) { }

        public void Subtitles()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }
        
        public void Comments()
        {
            Console.WriteLine("Comentários liberados na transmissão!");
        }

        public void Reccords()
        {
            Console.WriteLine("Gravação iniciada na transmissão!");
        }
    }
}
