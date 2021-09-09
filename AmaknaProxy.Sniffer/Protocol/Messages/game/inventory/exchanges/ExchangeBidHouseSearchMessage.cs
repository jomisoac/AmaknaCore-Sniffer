

// Generated on 09/08/2021 14:22:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeBidHouseSearchMessage : NetworkMessage
    {
        public const uint Id = 4493;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint genId;
        public bool follow;
        
        public ExchangeBidHouseSearchMessage()
        {
        }
        
        public ExchangeBidHouseSearchMessage(uint genId, bool follow)
        {
            this.genId = genId;
            this.follow = follow;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)genId);
            writer.WriteBoolean(follow);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            genId = reader.ReadVarUhShort();
            follow = reader.ReadBoolean();
        }
        
    }
    
}