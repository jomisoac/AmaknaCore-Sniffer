

// Generated on 09/01/2021 10:12:07
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StorageObjectsUpdateMessage : NetworkMessage
    {
        public const uint Id = 2221;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ObjectItem[] objectList;
        
        public StorageObjectsUpdateMessage()
        {
        }
        
        public StorageObjectsUpdateMessage(Types.ObjectItem[] objectList)
        {
            this.objectList = objectList;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objectList.Length);
            foreach (var entry in objectList)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objectList = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectList[i] = new Types.ObjectItem();
                 objectList[i].Deserialize(reader);
            }
        }
        
    }
    
}