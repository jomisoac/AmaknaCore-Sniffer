

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AccountHouseInformations : HouseInformations
    {
        public const short Id = 5019;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.HouseInstanceInformations houseInfos;
        public short worldX;
        public short worldY;
        public double mapId;
        public uint subAreaId;
        
        public AccountHouseInformations()
        {
        }
        
        public AccountHouseInformations(uint houseId, uint modelId, Types.HouseInstanceInformations houseInfos, short worldX, short worldY, double mapId, uint subAreaId)
         : base(houseId, modelId)
        {
            this.houseInfos = houseInfos;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(houseInfos.TypeId);
            houseInfos.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteDouble(mapId);
            writer.WriteVarShort((int)subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            houseInfos = ProtocolTypeManager.GetInstance<Types.HouseInstanceInformations>(reader.ReadUShort());
            houseInfos.Deserialize(reader);
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            mapId = reader.ReadDouble();
            subAreaId = reader.ReadVarUhShort();
        }
        
    }
    
}