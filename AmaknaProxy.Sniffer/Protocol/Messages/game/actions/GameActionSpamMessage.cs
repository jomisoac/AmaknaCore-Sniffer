

// Generated on 08/19/2021 23:34:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionSpamMessage : NetworkMessage
    {
        public const uint Id = 8082;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short[] cells;
        
        public GameActionSpamMessage()
        {
        }
        
        public GameActionSpamMessage(short[] cells)
        {
            this.cells = cells;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteShort(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            cells = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadShort();
            }
        }
        
    }
    
}