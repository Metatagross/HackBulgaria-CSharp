using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLMarkupBuilder
{
    public class XmlMarkupBuilder
    {
        private Stack<string> log;
        private List<string> document;
        private bool isOpen;
        private int counterTab;

        public XmlMarkupBuilder ( )
        {
            counterTab = -1;
            isOpen = true;
            log = new Stack<string>();
            document = new List<string>();
        }

        public XmlMarkupBuilder OpenTag ( String tagName )
        {
            if(!isOpen)
            {
                throw new InvalidOperationException("Your file is closed");
            }
            log.Push(tagName);
            counterTab++;
            StringBuilder displacement = new StringBuilder();
            for(int i = 0 ; i < counterTab ; i++)
            {
                displacement.Append("    ");
            }
            document.Add(displacement.ToString()+"<" + tagName + ">");
            return this;
        }
        public XmlMarkupBuilder AddAttr ( String attrName , String attrValue )
        {
            if(!isOpen)
            {
                throw new InvalidOperationException("Your file is closed");
            }
            string searchedTag = log.Peek();
            for(int i = document.Count - 1 ; i >= 0 ; i--)
            {
                if(document[i].Contains("<" + searchedTag))
                {
                    document[i]=document[i].Insert(document[i].LastIndexOf('>') , " " + attrName + "=" + "\""+attrValue+"\"");
                    break;
                }
            }
            return this;
        }
        public XmlMarkupBuilder AddText ( String text )
        {
            if(!isOpen)
            {
                throw new InvalidOperationException("Your file is closed");
            }
            if(!log.Any())
            {
                throw new ArgumentException("You cannot add text here");
            }
            StringBuilder displacement = new StringBuilder();
            for(int i = 0 ; i < counterTab+1 ; i++)
            {
                displacement.Append("    ");
            }
            document.Add(displacement.ToString()+text);
            return this;
        }
        public XmlMarkupBuilder CloseTag ( )
        {
            if(!isOpen)
            {
                throw new InvalidOperationException("Your file is closed");
            }
            if(!log.Any())
            {
                throw new InvalidOperationException("The tag you want to close doesn't exist");
            }
            StringBuilder displacement = new StringBuilder();
            for(int i = 0 ; i < counterTab ; i++)
            {
                displacement.Append("    ");
            }
            document.Add(displacement.ToString()+"</" + log.Pop() + ">");
            counterTab--;
            return this;
        }
        public XmlMarkupBuilder Finish ( )
        {
            if(!isOpen)
            {
                throw new InvalidOperationException("Your file is closed");
            }
            while(log.Any())
            {
                CloseTag();
            }
            isOpen = false;
            return this;
        }

        public String GetResult()
        {
            StringBuilder result = new StringBuilder();
            foreach(var item in document)
            {
                result.Append(item + "\n");
            }
            return result.ToString(); 
        } 
    }
}
