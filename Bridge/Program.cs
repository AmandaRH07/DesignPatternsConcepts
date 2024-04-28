using Bridge.Plataforms;
using Bridge.Transmissions;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartAdvancedLive(new YouTube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartAdvancedLive(new Instagram());

            Console.ReadLine();
        }

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new(platform);

            live.Broadcasting();
            live.Subtitles();
            live.Comments();
            live.Reccords();
            live.Result();
        }
    }
}
