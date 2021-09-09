

// Generated on 09/08/2021 14:21:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerSelectionMessage : NetworkMessage
    {
        public const uint Id = 6327;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint serverId;
        
        public ServerSelectionMessage()
        {
        }
        
        public ServerSelectionMessage(uint serverId)
        {
            this.serverId = serverId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)serverId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            serverId = reader.ReadVarUhShort();
        }
        
    }
    
}