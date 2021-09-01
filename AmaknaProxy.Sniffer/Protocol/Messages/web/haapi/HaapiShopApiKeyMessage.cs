

// Generated on 09/01/2021 10:12:11
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HaapiShopApiKeyMessage : NetworkMessage
    {
        public const uint Id = 2356;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string token;
        
        public HaapiShopApiKeyMessage()
        {
        }
        
        public HaapiShopApiKeyMessage(string token)
        {
            this.token = token;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(token);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            token = reader.ReadUTF();
        }
        
    }
    
}