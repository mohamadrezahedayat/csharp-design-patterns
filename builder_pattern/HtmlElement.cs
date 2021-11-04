using System;
using System.Collections.Generic;
using System.Text;

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
            Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        public HtmlElement() { }
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
}