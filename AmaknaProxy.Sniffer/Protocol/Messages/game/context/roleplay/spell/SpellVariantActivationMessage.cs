

// Generated on 08/19/2021 23:34:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SpellVariantActivationMessage : NetworkMessage
    {
        public const uint Id = 2077;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint spellId;
        public bool result;
        
        public SpellVariantActivationMessage()
        {
        }
        
        public SpellVariantActivationMessage(uint spellId, bool result)
        {
            this.spellId = spellId;
            this.result = result;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)spellId);
            writer.WriteBoolean(result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadVarUhShort();
            result = reader.ReadBoolean();
        }
        
    }
    
}