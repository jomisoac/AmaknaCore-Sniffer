

// Generated on 09/01/2021 10:11:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IgnoredDeleteResultMessage : NetworkMessage
    {
        public const uint Id = 1421;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool success;
        public bool session;
        public Types.AccountTagInformation tag;
        
        public IgnoredDeleteResultMessage()
        {
        }
        
        public IgnoredDeleteResultMessage(bool success, bool session, Types.AccountTagInformation tag)
        {
            this.success = success;
            this.session = session;
            this.tag = tag;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, success);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, session);
            writer.WriteByte(flag1);
            tag.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            success = BooleanByteWrapper.GetFlag(flag1, 0);
            session = BooleanByteWrapper.GetFlag(flag1, 1);
            tag = new Types.AccountTagInformation();
            tag.Deserialize(reader);
        }
        
    }
    
}