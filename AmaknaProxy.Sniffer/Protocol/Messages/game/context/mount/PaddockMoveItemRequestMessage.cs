

// Generated on 08/19/2021 23:34:28
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockMoveItemRequestMessage : NetworkMessage
    {
        public const uint Id = 630;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint oldCellId;
        public uint newCellId;
        
        public PaddockMoveItemRequestMessage()
        {
        }
        
        public PaddockMoveItemRequestMessage(uint oldCellId, uint newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)oldCellId);
            writer.WriteVarShort((int)newCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            oldCellId = reader.ReadVarUhShort();
            newCellId = reader.ReadVarUhShort();
        }
        
    }
    
}