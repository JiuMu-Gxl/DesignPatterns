using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrototypePattern
{
    [Serializable]
    public class Email : ICloneable
    {
        /// <summary>
        /// 发件人
        /// </summary>
        public User Sender { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public User Addressee { get; set; }

        /// <summary>
        /// 发件主题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 发件内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public Email ShallowCopy()
        {
            return this.Clone() as Email;
        }

        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <returns></returns>
        public Email DeepCopy()
        {
            var serializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (var stream = new System.IO.MemoryStream())
            {
                serializer.Serialize(stream, this);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                return serializer.Deserialize(stream) as Email;
            }
        }

        public override string ToString()
        {
            var newLine = Environment.NewLine;
            var indent = "\t";
            var str = $"发件人：{Sender.Name}({Sender.Email}){newLine}收件人：{Addressee.Name}({Addressee.Email}){newLine}主题：{Title}{newLine}内容：{newLine}{indent}致{Addressee.Name}：{newLine}{indent}{indent}{Content}";
            Console.WriteLine(str);
            return str;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
