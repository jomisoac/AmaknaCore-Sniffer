

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DebugHighlightCellsMessage : NetworkMessage
    {
        public const uint Id = 505;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double color;
        public uint[] cells;
        
        public DebugHighlightCellsMessage()
        {
        }
        
        public DebugHighlightCellsMessage(double color, uint[] cells)
        {
            this.color = color;
            this.cells = cells;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(color);
            writer.WriteShort((short)cells.Length);
            foreach (var entry in cells)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            color = reader.ReadDouble();
            var limit = (ushort)reader.ReadUShort();
            cells = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 cells[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}