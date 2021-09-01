

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PlayerStatus
    {
        public const short Id = 223;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte statusId;
        
        public PlayerStatus()
        {
        }
        
        public PlayerStatus(sbyte statusId)
        {
            this.statusId = statusId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(statusId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            statusId = reader.ReadSbyte();
        }
        
    }
    
}