using System.IO;
using System.Reflection;

namespace FusionPlusPlus.Engine.Tests
{
    internal static class DumpReader
    {
        internal static string Read(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"FusionPlusPlus.Engine.Tests.Dumps.{fileName}";

            using Stream stream = assembly.GetManifestResourceStream(resourceName) 
                ?? throw new NullReferenceException(nameof(stream));
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
    }
}
