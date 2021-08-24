

// Generated on 08/19/2021 23:34:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShowCellRequestMessage : NetworkMessage
    {
        public const uint Id = 5466;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public ShowCellRequestMessage()
        {
        }
        
        public ShowCellRequestMessage(uint cellId)
        {
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}