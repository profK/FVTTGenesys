using FVTTBridge.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVTTGenesys
{
    public class GenesysSystem : FoundrySystem
    {
        public override Type ActorType
        {
            get
            {
                return typeof(GenesysActor);
            }
        }

        public override Type ActorSheetType
        {
            get
            {
                return typeof(GenesysActorSheet);
            }
        }
    }
}
