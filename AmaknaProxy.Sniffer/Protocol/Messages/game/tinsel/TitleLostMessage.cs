

// Generated on 09/01/2021 10:12:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TitleLostMessage : NetworkMessage
    {
        public const uint Id = 853;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint titleId;
        
        public TitleLostMessage()
        {
        }
        
        public TitleLostMessage(uint titleId)
        {
            this.titleId = titleId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)titleId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            titleId = reader.ReadVarUhShort();
        }
        
    }
    
}