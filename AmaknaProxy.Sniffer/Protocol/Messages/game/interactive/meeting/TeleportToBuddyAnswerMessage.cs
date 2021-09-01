

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportToBuddyAnswerMessage : NetworkMessage
    {
        public const uint Id = 6804;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint dungeonId;
        public double buddyId;
        public bool accept;
        
        public TeleportToBuddyAnswerMessage()
        {
        }
        
        public TeleportToBuddyAnswerMessage(uint dungeonId, double buddyId, bool accept)
        {
            this.dungeonId = dungeonId;
            this.buddyId = buddyId;
            this.accept = accept;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(buddyId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            buddyId = reader.ReadVarUhLong();
            accept = reader.ReadBoolean();
        }
        
    }
    
}