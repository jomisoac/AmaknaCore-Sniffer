

// Generated on 09/08/2021 14:21:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PauseDialogMessage : NetworkMessage
    {
        public const uint Id = 1952;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte dialogType;
        
        public PauseDialogMessage()
        {
        }
        
        public PauseDialogMessage(sbyte dialogType)
        {
            this.dialogType = dialogType;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(dialogType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            dialogType = reader.ReadSbyte();
        }
        
    }
    
}