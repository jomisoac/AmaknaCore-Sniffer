

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ActorOrientation
    {
        public const short Id = 6675;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double id;
        public sbyte direction;
        
        public ActorOrientation()
        {
        }
        
        public ActorOrientation(double id, sbyte direction)
        {
            this.id = id;
            this.direction = direction;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(id);
            writer.WriteSbyte(direction);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadDouble();
            direction = reader.ReadSbyte();
        }
        
    }
    
}