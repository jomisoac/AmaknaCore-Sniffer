

// Generated on 09/01/2021 10:12:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismSetSabotagedRefusedMessage : NetworkMessage
    {
        public const uint Id = 527;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        public sbyte reason;
        
        public PrismSetSabotagedRefusedMessage()
        {
        }
        
        public PrismSetSabotagedRefusedMessage(uint subAreaId, sbyte reason)
        {
            this.subAreaId = subAreaId;
            this.reason = reason;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSbyte(reason);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subAreaId = reader.ReadVarUhShort();
            reason = reader.ReadSbyte();
        }
        
    }
    
}