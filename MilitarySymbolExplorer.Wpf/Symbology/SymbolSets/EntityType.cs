using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public class EntityType : DomainCoded
    {
        public EntityType(string name, string identifier)
        : base(name, identifier)
        {
        }
    }
}
