using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    public class AuthorSerializer: IAuthorSerializer
    {
        public void SerializeAuthor(string path, Author a)
        {
            List <Author> list= DeserializeAuthor(path);
            list.Add(a);
            if(!File.Exists(path))
            {  // file does not exist
                using(File.Create(path)) { };
            }

            var bFormatter2 = new BinaryFormatter();
            using(var stream = File.OpenWrite(path))
            {  // serialize
                bFormatter2.Serialize(stream , list);
                stream.Close();
            }
        }

        public List<Author> DeserializeAuthor(string path)
        {
            List<Author> list = new List<Author>();
            if(!File.Exists(path))
            {
            }
            else
            {
                var bFormatter = new BinaryFormatter();
                using(var stream = File.OpenRead(path))
                {
                    list.AddRange((ICollection<Author>)bFormatter.Deserialize(stream));
                    stream.Close();
                }
            }
            return list;
        }
    }
}
