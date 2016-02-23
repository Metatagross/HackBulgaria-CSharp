using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLMarkupBuilder;

namespace XMLBuilderExample
{
    class Example
    {
        static void Main ( string[] args )
        {
            XmlMarkupBuilder doc = new XmlMarkupBuilder();
            doc.OpenTag("menu");
            doc.AddAttr("time" , "AfterNoon");
            doc.OpenTag("meal");
            doc.OpenTag("salat");
            doc.AddText("food");
            doc.CloseTag();
            doc.OpenTag("recipe");
            doc.AddText("Here!");
            doc.CloseTag();
            doc.AddText("End of story!");
            doc.Finish();
            Console.WriteLine(doc.GetResult());
            Console.ReadKey();
        }
    }
}
