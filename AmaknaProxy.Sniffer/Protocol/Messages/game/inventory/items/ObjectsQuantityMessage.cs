

// Generated on 09/01/2021 10:12:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectsQuantityMessage : NetworkMessage
    {
        public const uint Id = 5816;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItemQuantity[] objectsUIDAndQty;
        
        public ObjectsQuantityMessage()
        {
        }
        
        public ObjectsQuantityMessage(Types.ObjectItemQuantity[] objectsUIDAndQty)
        {
            this.objectsUIDAndQty = objectsUIDAndQty;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objectsUIDAndQty.Length);
            foreach (var entry in objectsUIDAndQty)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objectsUIDAndQty = new Types.ObjectItemQuantity[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsUIDAndQty[i] = new Types.ObjectItemQuantity();
                 objectsUIDAndQty[i].Deserialize(reader);
            }
        }
        
    }
    
}