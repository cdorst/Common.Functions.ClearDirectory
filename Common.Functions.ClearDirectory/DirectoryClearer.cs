using Common.Functions.ResolveRelativePath;
using static Common.Functions.CreateDirectory.DirectoryCreator;
using static System.IO.Directory;

namespace Common.Functions.ClearDirectory
{
    public static class DirectoryClearer
    {
        public static void ClearDirectory(string path)
        {
            if (Exists(path)) Delete(path, recursive: true);
            Create(path);
        }

        public static void ClearRelativeDirectory(string pathRelativeToCurrent)
            => ClearDirectory(
                RelativePathResolver.GetPath(pathRelativeToCurrent));
    }
}
