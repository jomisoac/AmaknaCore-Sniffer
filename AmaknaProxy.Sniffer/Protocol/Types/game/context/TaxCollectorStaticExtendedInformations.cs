

// Generated on 09/08/2021 14:22:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class TaxCollectorStaticExtendedInformations : TaxCollectorStaticInformations
    {
        public const short Id = 6146;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public Types.AllianceInformations allianceIdentity;
        
        public TaxCollectorStaticExtendedInformations()
        {
        }
        
        public TaxCollectorStaticExtendedInformations(uint firstNameId, uint lastNameId, Types.GuildInformations guildIdentity, double callerId, Types.AllianceInformations allianceIdentity)
         : base(firstNameId, lastNameId, guildIdentity, callerId)
        {
            this.allianceIdentity = allianceIdentity;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            allianceIdentity.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            allianceIdentity = new Types.AllianceInformations();
            allianceIdentity.Deserialize(reader);
        }
        
    }
    
}