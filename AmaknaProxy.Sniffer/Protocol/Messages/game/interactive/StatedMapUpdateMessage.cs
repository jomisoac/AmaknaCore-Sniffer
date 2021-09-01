

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StatedMapUpdateMessage : NetworkMessage
    {
        public const uint Id = 4814;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.StatedElement[] statedElements;
        
        public StatedMapUpdateMessage()
        {
        }
        
        public StatedMapUpdateMessage(Types.StatedElement[] statedElements)
        {
            this.statedElements = statedElements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)statedElements.Length);
            foreach (var entry in statedElements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            statedElements = new Types.StatedElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 statedElements[i] = new Types.StatedElement();
                 statedElements[i].Deserialize(reader);
            }
        }
        
    }
    
}