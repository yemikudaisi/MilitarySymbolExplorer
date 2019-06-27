using System;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public abstract class DomainCoded : IComparable
    {
        public string Name { get; set; }
        public string Identifier { get; set; }

        public DomainCoded(string name, string identifier)
        {
            Name = name;
            Identifier = identifier;
        }

        public int CompareTo(object obj)
        {
            return string.Compare(this.Name, ((DomainCoded)obj).Name);
        }
    }
}
