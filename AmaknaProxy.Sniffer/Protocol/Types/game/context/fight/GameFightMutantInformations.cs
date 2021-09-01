

// Generated on 09/01/2021 10:12:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightMutantInformations : GameFightFighterNamedInformations
    {
        public const short Id = 3991;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte powerLevel;
        
        public GameFightMutantInformations()
        {
        }
        
        public GameFightMutantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, string name, Types.PlayerStatus status, int leagueId, int ladderPosition, bool hiddenInPrefight, sbyte powerLevel)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions, name, status, leagueId, ladderPosition, hiddenInPrefight)
        {
            this.powerLevel = powerLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(powerLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            powerLevel = reader.ReadSbyte();
        }
        
    }
    
}