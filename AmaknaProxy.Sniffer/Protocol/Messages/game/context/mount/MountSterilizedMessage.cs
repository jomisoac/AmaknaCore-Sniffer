

// Generated on 08/19/2021 23:34:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountSterilizedMessage : NetworkMessage
    {
        public const uint Id = 8630;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int mountId;
        
        public MountSterilizedMessage()
        {
        }
        
        public MountSterilizedMessage(int mountId)
        {
            this.mountId = mountId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)mountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountId = reader.ReadVarInt();
        }
        
    }
    
}