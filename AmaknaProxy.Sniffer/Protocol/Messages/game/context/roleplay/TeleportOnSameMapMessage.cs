

// Generated on 09/08/2021 14:21:50
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TeleportOnSameMapMessage : NetworkMessage
    {
        public const uint Id = 6365;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public uint cellId;
        
        public TeleportOnSameMapMessage()
        {
        }
        
        public TeleportOnSameMapMessage(double targetId, uint cellId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(targetId);
            writer.WriteVarShort((int)cellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            targetId = reader.ReadDouble();
            cellId = reader.ReadVarUhShort();
        }
        
    }
    
}