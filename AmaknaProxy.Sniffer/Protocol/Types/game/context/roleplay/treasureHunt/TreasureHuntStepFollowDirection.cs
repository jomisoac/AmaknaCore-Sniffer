

// Generated on 09/01/2021 10:12:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        public const short Id = 3436;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte direction;
        public uint mapCount;
        
        public TreasureHuntStepFollowDirection()
        {
        }
        
        public TreasureHuntStepFollowDirection(sbyte direction, uint mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(direction);
            writer.WriteVarShort((int)mapCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            direction = reader.ReadSbyte();
            mapCount = reader.ReadVarUhShort();
        }
        
    }
    
}