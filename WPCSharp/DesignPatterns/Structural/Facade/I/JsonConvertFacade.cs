using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade.I
{
    public class JsonConvertFacade
    {
        private static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings()
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            Formatting = Formatting.Indented
        };

        public static string Serialize<T>(T @object)
        {
            return JsonConvert.SerializeObject(@object, Settings);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
