using System;
using System.Collections.Generic;

namespace Single_Responsibility_Principle
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();
        private static int _count;

        public int AddEntry(string text)
        {
            _entries.Add($"{++_count}: {text}");
            return _count; //memento
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine,_entries);
        }
    }
}