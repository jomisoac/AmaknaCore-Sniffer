

// Generated on 09/01/2021 10:11:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ChatSmileyRequestMessage : NetworkMessage
    {
        public const uint Id = 3196;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint smileyId;
        
        public ChatSmileyRequestMessage()
        {
        }
        
        public ChatSmileyRequestMessage(uint smileyId)
        {
            this.smileyId = smileyId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)smileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            smileyId = reader.ReadVarUhShort();
        }
        
    }
    
}