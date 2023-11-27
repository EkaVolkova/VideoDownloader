using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace VideoDownloader
{
    /// <summary>
    /// Класс реализации интерфейса команды для получения информации о видео
    /// </summary>
    public class InformationCommand : ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public async Task Run(string link)
        {
            var client = new YoutubeClient();
            var video = await client.Videos.GetAsync(link);
            var title = video.Title; 
            var author = video.Author.Title; 
            var description = video.Description;
            Console.WriteLine($"Название: {title}\r\nАвтор: {author}\r\nОписание: {description}");
        }
    }
}
