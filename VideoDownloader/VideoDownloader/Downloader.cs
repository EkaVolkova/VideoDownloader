
using System.Threading.Tasks;

namespace VideoDownloader
{
    /// <summary>
    /// Класс исполнитель команды
    /// </summary>
    public class Downloader 
    {
        ICommand command;

        /// <summary>
        /// Установить команду
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Выполнить команду
        /// </summary>
        /// <param name="link"></param>
        public async Task RunAsync(string link)
        {
            await command.Run(link);
        }
    }

}
