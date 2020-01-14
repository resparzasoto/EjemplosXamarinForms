using System.Threading.Tasks;

namespace WriteFile
{
    public interface IFileSystemService
    {
        Task WriteFileAsync(string fileName, string content);

        Task<string> GetContentFileAsync(string fileName);

        string GetPath(string fileName);
    }
}
