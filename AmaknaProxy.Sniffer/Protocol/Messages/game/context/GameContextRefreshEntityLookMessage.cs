

// Generated on 09/01/2021 10:11:42
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameContextRefreshEntityLookMessage : NetworkMessage
    {
        public const uint Id = 6261;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double id;
        public Types.EntityLook look;
        
        public GameContextRefreshEntityLookMessage()
        {
        }
        
        public GameContextRefreshEntityLookMessage(double id, Types.EntityLook look)
        {
            this.id = id;
            this.look = look;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
            look.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
            look = new Types.EntityLook();
            look.Deserialize(reader);
        }
        
    }
    
}