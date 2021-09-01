

// Generated on 09/01/2021 10:12:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TaxCollectorMovementMessage : NetworkMessage
    {
        public const uint Id = 4295;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public double playerId;
        public string playerName;
        
        public TaxCollectorMovementMessage()
        {
        }
        
        public TaxCollectorMovementMessage(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            movementType = reader.ReadSbyte();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
        }
        
    }
    
}