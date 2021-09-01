

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AcquaintanceInformation : AbstractContactInformations
    {
        public const short Id = 1;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte playerState;
        
        public AcquaintanceInformation()
        {
        }
        
        public AcquaintanceInformation(int accountId, Types.AccountTagInformation accountTag, sbyte playerState)
         : base(accountId, accountTag)
        {
            this.playerState = playerState;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(playerState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            playerState = reader.ReadSbyte();
        }
        
    }
    
}