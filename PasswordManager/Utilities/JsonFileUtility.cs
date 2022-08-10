using Newtonsoft.Json;
using System.IO;

namespace PasswordManager.Utilities
{
    public class JsonFileUtility
    {
        public T ReadFile<T>(string path)
        {
            using (var file = new StreamReader(path))
            {
                var json = file.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        public void SaveFile<T>(string path, T data)
        {
            using (var file = new StreamWriter(path))
            {
                file.Write(JsonConvert.SerializeObject(data));
            }
        }
    }
}
