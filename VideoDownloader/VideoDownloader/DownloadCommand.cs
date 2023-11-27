using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace VideoDownloader
{
    /// <summary>
    /// Класс реализации интерфейса команды для скачивания видео
    /// </summary>
    public class DownloadCommand : ICommand
    {
        /// <summary>
        /// Реализация команды скачивания видео
        /// </summary>
        /// <param name="link">ссылка на видео</param>
        /// <returns></returns>
        public async Task Run(string link)
        {
            var client = new YoutubeClient();
            await client.Videos.DownloadAsync(link, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast));
            Console.WriteLine("Видео загружено!");
        }
    }
}
