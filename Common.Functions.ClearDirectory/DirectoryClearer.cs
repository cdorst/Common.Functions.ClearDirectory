using static Common.Functions.CreateDirectory.DirectoryCreator;
using static Common.Functions.ResolveRelativePath.RelativePathResolver;
using static System.IO.Directory;

namespace Common.Functions.ClearDirectory
{
    public static class DirectoryClearer
    {
        public static void Clear(string path, bool relativePath = false)
        {
            if (relativePath) path = GetPath(path);
            if (Exists(path)) Delete(path, recursive: true);
            Create(path);
        }
    }
}
