

// Generated on 09/08/2021 14:22:02
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildSpellUpgradeRequestMessage : NetworkMessage
    {
        public const uint Id = 8606;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int spellId;
        
        public GuildSpellUpgradeRequestMessage()
        {
        }
        
        public GuildSpellUpgradeRequestMessage(int spellId)
        {
            this.spellId = spellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(spellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            spellId = reader.ReadInt();
        }
        
    }
    
}