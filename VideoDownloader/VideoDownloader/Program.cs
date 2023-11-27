using System;
using System.IO;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace VideoDownloader
{
    class Program
    {


        static async Task Main(string[] args)
        {
            //Создали объект класса Downloader
            Downloader downloader = new Downloader();
            //Получили ссылку на видео
            Console.WriteLine("Введите ссылку на видео");
            var link = Console.ReadLine();

           

            //установили команду на считывание информации
            downloader.SetCommand(new InformationCommand());

            //запустили считывание
            await downloader.RunAsync(link);

            //Установили команду на скачивание файла
            downloader.SetCommand(new DownloadCommand());

            //запустили скачивание
            await downloader.RunAsync(link);

        }

    }
}
