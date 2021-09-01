

// Generated on 09/01/2021 10:11:45
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameDataPaddockObjectRemoveMessage : NetworkMessage
    {
        public const uint Id = 3645;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        
        public GameDataPaddockObjectRemoveMessage()
        {
        }
        
        public GameDataPaddockObjectRemoveMessage(uint cellId)
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