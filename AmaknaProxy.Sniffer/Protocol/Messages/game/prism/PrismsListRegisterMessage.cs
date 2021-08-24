

// Generated on 08/19/2021 23:34:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismsListRegisterMessage : NetworkMessage
    {
        public const uint Id = 4752;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte listen;
        
        public PrismsListRegisterMessage()
        {
        }
        
        public PrismsListRegisterMessage(sbyte listen)
        {
            this.listen = listen;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(listen);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            listen = reader.ReadSbyte();
        }
        
    }
    
}