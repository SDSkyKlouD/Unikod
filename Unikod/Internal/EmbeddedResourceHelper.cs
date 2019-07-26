using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SDSK.Libs.Unikod.Internal {
    internal static class EmbeddedResourceHelper {
        internal static Stream GetEmbeddedResourceStream(string resourceFilePath) {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string path = $"{assembly.GetName()}.Resources.{resourceFilePath.Replace(" ", "_").Replace("\\", ".").Replace("/", ".")}";

            return assembly.GetManifestResourceStream(path);
        }

        internal static async Task<string> ReadEmbeddedResourceAsync(string resourceFilePath) {
            string data = null;

            using(Stream stream = GetEmbeddedResourceStream(resourceFilePath)) {
                using(StreamReader reader = new StreamReader(stream)) {
                    data = await reader.ReadToEndAsync();
                }
            }

            return data;
        }

        internal static async Task<JObject> ParseJsonFromEmbeddedResourceAsync(string resourceFilePath)
            => JObject.Parse(await ReadEmbeddedResourceAsync(resourceFilePath));
    }
}
