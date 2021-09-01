

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class InteractiveMapUpdateMessage : NetworkMessage
    {
        public const uint Id = 6385;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.InteractiveElement[] interactiveElements;
        
        public InteractiveMapUpdateMessage()
        {
        }
        
        public InteractiveMapUpdateMessage(Types.InteractiveElement[] interactiveElements)
        {
            this.interactiveElements = interactiveElements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)interactiveElements.Length);
            foreach (var entry in interactiveElements)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            interactiveElements = new Types.InteractiveElement[limit];
            for (int i = 0; i < limit; i++)
            {
                 interactiveElements[i] = ProtocolTypeManager.GetInstance<Types.InteractiveElement>(reader.ReadUShort());
                 interactiveElements[i].Deserialize(reader);
            }
        }
        
    }
    
}