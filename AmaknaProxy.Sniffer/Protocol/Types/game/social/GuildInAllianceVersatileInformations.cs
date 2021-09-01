

// Generated on 09/01/2021 10:12:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildInAllianceVersatileInformations : GuildVersatileInformations
    {
        public const short Id = 2686;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint allianceId;
        
        public GuildInAllianceVersatileInformations()
        {
        }
        
        public GuildInAllianceVersatileInformations(uint guildId, double leaderId, byte guildLevel, byte nbMembers, uint allianceId)
         : base(guildId, leaderId, guildLevel, nbMembers)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt((int)allianceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
        }
        
    }
    
}