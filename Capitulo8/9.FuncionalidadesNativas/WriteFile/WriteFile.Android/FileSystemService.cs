using System;
using System.IO;
using System.Threading.Tasks;
using WriteFile.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileSystemService))]
namespace WriteFile.Droid
{
    public class FileSystemService : IFileSystemService
    {
        public async Task WriteFileAsync(string fileName, string content)
        {
            var path = GetPath(fileName);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (var stream = File.Create(path))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    await streamWriter.WriteLineAsync(content);
                }
            }
        }

        public async Task<string> GetContentFileAsync(string fileName)
        {
            var path = GetPath(fileName);

            if (File.Exists(path))
            {
                return await File.ReadAllTextAsync(path);
            }
            else
            {
                return await Task.FromResult("");
            }
        }

        public string GetPath(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
        }
    }
}