

// Generated on 09/01/2021 10:11:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountRenamedMessage : NetworkMessage
    {
        public const uint Id = 197;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int mountId;
        public string name;
        
        public MountRenamedMessage()
        {
        }
        
        public MountRenamedMessage(int mountId, string name)
        {
            this.mountId = mountId;
            this.name = name;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)mountId);
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mountId = reader.ReadVarInt();
            name = reader.ReadUTF();
        }
        
    }
    
}