using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    public interface IAuthorSerializer
    {
        void SerializeAuthor(string path,Author a);
        List<Author> DeserializeAuthor(string path);

    }
}
