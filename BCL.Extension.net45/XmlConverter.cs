using System.IO;
using System.Xml.Serialization;

namespace BCL.Extension
{
    /// <summary>
    ///     对象和Xml的序列化和反序列化
    /// </summary>
    public static class XmlConverter
    {
        /// <summary>
        ///     从Xml文件反序列化出对象
        /// </summary>
        /// <param name="path"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T DeserializeFile<T>(string path)
        {
            return (T) new XmlSerializer(typeof (T)).Deserialize(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite));
        }

        /// <summary>
        ///     序列化至Xml文件
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        public static void SerializeFile(object obj, string path)
        {
            new XmlSerializer(obj.GetType()).Serialize(new FileStream(path, FileMode.Create, FileAccess.ReadWrite), obj);
        }

        /// <summary>
        ///     从字符串反序列化出对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string xml)
        {
            using (var reader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof (T));
                return (T) serializer.Deserialize(reader);
            }
        }

        /// <summary>
        ///     序列化成字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            //using (var stream = new MemoryStream())
            //{
            //    var serializer = new XmlSerializer(obj.GetType());
            //    serializer.Serialize(stream, obj);
            //    using (var sr = new StreamReader(stream))
            //    {
            //        return sr.ReadToEnd();
            //    }
            //}
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
    }
}