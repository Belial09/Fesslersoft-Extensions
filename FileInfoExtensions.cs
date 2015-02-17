using System.IO;

namespace Fesslersoft.Extensions
{
    public static class FileInfoExtensions
    {
        /// <summary>
        /// Changes the extension of a File.
        /// </summary>
        /// <param name="file">The FileInfo of the source file.</param>
        /// <param name="newExtension">The new File extension for the returned FileInfo.</param>
        /// <returns></returns>
        public static FileInfo ChangeExtension(FileInfo file, string newExtension)
        {
            if (!newExtension.StartsWith("."))
            {
                newExtension = "." + newExtension;
            }
            var fileName = string.Concat(Path.GetFileNameWithoutExtension(file.FullName), newExtension);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.Move(file.FullName,fileName);
            if (File.Exists(fileName))
            {
                File.Delete(file.FullName);
            }
            return new FileInfo(fileName);
        }
    }
}
