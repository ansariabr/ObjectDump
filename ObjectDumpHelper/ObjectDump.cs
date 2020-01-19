using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace ObjectDumpHelper
{
    public static class ObjectDump
    {
        private static JsonSerializerOptions GetDefaultJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }

        /// <summary>
        /// Returns string of properties and values of the given object using System.Text.Json serializer
        /// </summary>
        /// <param name="objectToDump"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        private static string GetObjectString(object objectToDump, JsonSerializerOptions jsonSerializerOptions)
        {
            if (objectToDump == null)
                throw new ArgumentNullException(nameof(objectToDump));
            return JsonSerializer.Serialize(objectToDump, jsonSerializerOptions);
        }

        /// <summary>
        /// Dump all values to console
        /// </summary>
        /// <param name="objectToDump"></param>
        public static void DumpProperties(this object objectToDump)
        {
            string jsonString = GetObjectString(objectToDump, GetDefaultJsonSerializerOptions());
            Console.WriteLine(jsonString);
        }

        /// <summary>
        /// Dump all values using the provided logger and options
        /// </summary>
        /// <param name="objectToDump"></param>
        /// <param name="logger"></param>
        public static void DumpProperties(this object objectToDump, ILogger logger, JsonSerializerOptions jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions == null)
                jsonSerializerOptions = GetDefaultJsonSerializerOptions();
            string jsonString = GetObjectString(objectToDump, jsonSerializerOptions);
            logger.LogInformation(jsonString);
        }

        /// <summary>
        /// Returns the string with properties and values of provided object
        /// </summary>
        /// <param name="objectToDump"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        public static string GetObjectProperties(this object objectToDump, JsonSerializerOptions jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions == null)
                jsonSerializerOptions = GetDefaultJsonSerializerOptions();
            return GetObjectString(objectToDump, jsonSerializerOptions);
        }
    }
}
