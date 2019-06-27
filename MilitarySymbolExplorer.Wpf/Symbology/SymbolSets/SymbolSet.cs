using System;
using System.Collections.Generic;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public class SymbolSet : DomainCoded
    {
        public SymbolSet(string name, string identifier, IList<Entity> entities)
            : base(name, identifier)
        {            
            Entities = entities;
        }

        public IList<Entity> Entities { get; set; }
    }
}
