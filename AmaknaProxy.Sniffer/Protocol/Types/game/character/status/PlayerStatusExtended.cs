

// Generated on 09/01/2021 10:12:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PlayerStatusExtended : PlayerStatus
    {
        public const short Id = 4104;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public string message;
        
        public PlayerStatusExtended()
        {
        }
        
        public PlayerStatusExtended(sbyte statusId, string message)
         : base(statusId)
        {
            this.message = message;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(message);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            message = reader.ReadUTF();
        }
        
    }
    
}