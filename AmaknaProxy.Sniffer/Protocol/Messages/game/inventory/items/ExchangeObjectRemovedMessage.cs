

// Generated on 09/01/2021 10:12:06
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        public const uint Id = 2518;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint objectUID;
        
        public ExchangeObjectRemovedMessage()
        {
        }
        
        public ExchangeObjectRemovedMessage(bool remote, uint objectUID)
         : base(remote)
        {
            this.objectUID = objectUID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectUID = reader.ReadVarUhInt();
        }
        
    }
    
}