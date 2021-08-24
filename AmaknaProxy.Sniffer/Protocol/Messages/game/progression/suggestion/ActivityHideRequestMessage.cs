

// Generated on 08/19/2021 23:34:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ActivityHideRequestMessage : NetworkMessage
    {
        public const uint Id = 1908;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint activityId;
        
        public ActivityHideRequestMessage()
        {
        }
        
        public ActivityHideRequestMessage(uint activityId)
        {
            this.activityId = activityId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)activityId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            activityId = reader.ReadVarUhShort();
        }
        
    }
    
}