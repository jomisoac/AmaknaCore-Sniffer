

// Generated on 08/19/2021 23:35:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class BufferInformation
    {
        public const short Id = 7219;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double id;
        public double amount;
        
        public BufferInformation()
        {
        }
        
        public BufferInformation(double id, double amount)
        {
            this.id = id;
            this.amount = amount;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(id);
            writer.WriteVarLong(amount);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            id = reader.ReadVarUhLong();
            amount = reader.ReadVarUhLong();
        }
        
    }
    
}