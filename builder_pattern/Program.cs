using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int IndentSize = 2;

        public HtmlElement(string name, string text)
        {
            Name = name?? throw new ArgumentNullException(paramName:nameof(name));
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text)); ;
        }

        public HtmlElement()
        {
            
        }
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new String(' ', IndentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            if (!String.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new String(' ', IndentSize * indent + 1));
                sb.AppendLine(Text);
            }

            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i}</{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    public class HtmlBuilder
    {
        private readonly string _rootName;
        private HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement {Name = _rootName};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li","hello");
            builder.AddChild("li", "world");
            WriteLine(builder.ToString());
            ReadLine();
        }
    }
}
