

// Generated on 09/01/2021 10:11:51
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LockableShowCodeDialogMessage : NetworkMessage
    {
        public const uint Id = 5688;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool changeOrUse;
        public sbyte codeSize;
        
        public LockableShowCodeDialogMessage()
        {
        }
        
        public LockableShowCodeDialogMessage(bool changeOrUse, sbyte codeSize)
        {
            this.changeOrUse = changeOrUse;
            this.codeSize = codeSize;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(changeOrUse);
            writer.WriteSbyte(codeSize);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            changeOrUse = reader.ReadBoolean();
            codeSize = reader.ReadSbyte();
        }
        
    }
    
}