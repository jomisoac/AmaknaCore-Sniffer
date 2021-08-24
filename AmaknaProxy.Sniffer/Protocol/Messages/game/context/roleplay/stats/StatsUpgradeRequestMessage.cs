

// Generated on 08/19/2021 23:34:39
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StatsUpgradeRequestMessage : NetworkMessage
    {
        public const uint Id = 5276;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool useAdditionnal;
        public sbyte statId;
        public uint boostPoint;
        
        public StatsUpgradeRequestMessage()
        {
        }
        
        public StatsUpgradeRequestMessage(bool useAdditionnal, sbyte statId, uint boostPoint)
        {
            this.useAdditionnal = useAdditionnal;
            this.statId = statId;
            this.boostPoint = boostPoint;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(useAdditionnal);
            writer.WriteSbyte(statId);
            writer.WriteVarShort((int)boostPoint);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            useAdditionnal = reader.ReadBoolean();
            statId = reader.ReadSbyte();
            boostPoint = reader.ReadVarUhShort();
        }
        
    }
    
}