

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class MapCoordinatesExtended : MapCoordinatesAndId
    {
        public const short Id = 1133;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint subAreaId;
        
        public MapCoordinatesExtended()
        {
        }
        
        public MapCoordinatesExtended(short worldX, short worldY, double mapId, uint subAreaId)
         : base(worldX, worldY, mapId)
        {
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}