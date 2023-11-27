using System.Threading.Tasks;

namespace VideoDownloader
{
    /// <summary>
    /// Интерфейс комманд 
    /// </summary>
    public interface ICommand
    {
        public Task Run(string link);
    }
}
