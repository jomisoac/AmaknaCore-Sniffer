

// Generated on 08/19/2021 23:35:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightTeamMemberWithAllianceCharacterInformations : FightTeamMemberCharacterInformations
    {
        public const short Id = 3733;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.BasicAllianceInformations allianceInfos;
        
        public FightTeamMemberWithAllianceCharacterInformations()
        {
        }
        
        public FightTeamMemberWithAllianceCharacterInformations(double id, string name, uint level, Types.BasicAllianceInformations allianceInfos)
         : base(id, name, level)
        {
            this.allianceInfos = allianceInfos;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            allianceInfos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            allianceInfos = new Types.BasicAllianceInformations();
            allianceInfos.Deserialize(reader);
        }
        
    }
    
}