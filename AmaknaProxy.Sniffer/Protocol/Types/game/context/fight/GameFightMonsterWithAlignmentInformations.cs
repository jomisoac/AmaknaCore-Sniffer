

// Generated on 09/01/2021 10:12:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameFightMonsterWithAlignmentInformations : GameFightMonsterInformations
    {
        public const short Id = 9829;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.ActorAlignmentInformations alignmentInfos;
        
        public GameFightMonsterWithAlignmentInformations()
        {
        }
        
        public GameFightMonsterWithAlignmentInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, Types.GameContextBasicSpawnInformation spawnInfo, sbyte wave, Types.GameFightCharacteristics stats, uint[] previousPositions, uint creatureGenericId, sbyte creatureGrade, short creatureLevel, Types.ActorAlignmentInformations alignmentInfos)
         : base(contextualId, disposition, look, spawnInfo, wave, stats, previousPositions, creatureGenericId, creatureGrade, creatureLevel)
        {
            this.alignmentInfos = alignmentInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            alignmentInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            alignmentInfos = new Types.ActorAlignmentInformations();
            alignmentInfos.Deserialize(reader);
        }
        
    }
    
}