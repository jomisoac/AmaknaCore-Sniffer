

// Generated on 09/01/2021 10:12:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildFactSheetInformations : GuildInformations
    {
        public const short Id = 8504;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double leaderId;
        public uint nbMembers;
        
        public GuildFactSheetInformations()
        {
        }
        
        public GuildFactSheetInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem, double leaderId, uint nbMembers)
         : base(guildId, guildName, guildLevel, guildEmblem)
        {
            this.leaderId = leaderId;
            this.nbMembers = nbMembers;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(leaderId);
            writer.WriteVarShort((int)nbMembers);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            leaderId = reader.ReadVarUhLong();
            nbMembers = reader.ReadVarUhShort();
        }
        
    }
    
}