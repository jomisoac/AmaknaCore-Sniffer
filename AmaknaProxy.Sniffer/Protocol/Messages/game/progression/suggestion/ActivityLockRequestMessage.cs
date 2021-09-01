

// Generated on 09/01/2021 10:12:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ActivityLockRequestMessage : NetworkMessage
    {
        public const uint Id = 7407;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint activityId;
        public bool @lock;
        
        public ActivityLockRequestMessage()
        {
        }
        
        public ActivityLockRequestMessage(uint activityId, bool @lock)
        {
            this.activityId = activityId;
            this.@lock = @lock;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)activityId);
            writer.WriteBoolean(@lock);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            activityId = reader.ReadVarUhShort();
            @lock = reader.ReadBoolean();
        }
        
    }
    
}