

// Generated on 09/01/2021 10:11:46
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PaddockRemoveItemRequestMessage : NetworkMessage
    {
        public const uint Id = 6064;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public PaddockRemoveItemRequestMessage()
        {
        }
        
        public PaddockRemoveItemRequestMessage(uint cellId)
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