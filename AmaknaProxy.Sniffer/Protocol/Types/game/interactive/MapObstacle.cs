

// Generated on 09/08/2021 14:22:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MapObstacle
    {
        public const short Id = 7167;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint obstacleCellId;
        public sbyte state;
        
        public MapObstacle()
        {
        }
        
        public MapObstacle(uint obstacleCellId, sbyte state)
        {
            this.obstacleCellId = obstacleCellId;
            this.state = state;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)obstacleCellId);
            writer.WriteSbyte(state);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            obstacleCellId = reader.ReadVarUhShort();
            state = reader.ReadSbyte();
        }
        
    }
    
}