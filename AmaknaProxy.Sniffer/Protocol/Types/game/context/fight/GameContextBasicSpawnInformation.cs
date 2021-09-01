

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameContextBasicSpawnInformation
    {
        public const short Id = 3043;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte teamId;
        public bool alive;
        public Types.GameContextActorPositionInformations informations;
        
        public GameContextBasicSpawnInformation()
        {
        }
        
        public GameContextBasicSpawnInformation(sbyte teamId, bool alive, Types.GameContextActorPositionInformations informations)
        {
            this.teamId = teamId;
            this.alive = alive;
            this.informations = informations;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(teamId);
            writer.WriteBoolean(alive);
            writer.WriteShort(informations.TypeId);
            informations.Serialize(writer);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            teamId = reader.ReadSbyte();
            alive = reader.ReadBoolean();
            informations = ProtocolTypeManager.GetInstance<Types.GameContextActorPositionInformations>(reader.ReadUShort());
            informations.Deserialize(reader);
        }
        
    }
    
}