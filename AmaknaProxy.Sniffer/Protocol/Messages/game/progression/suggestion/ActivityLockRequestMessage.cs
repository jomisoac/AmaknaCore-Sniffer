

// Generated on 09/08/2021 14:22:12
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
        public bool m_lock;
        
        public ActivityLockRequestMessage()
        {
        }
        
        public ActivityLockRequestMessage(uint activityId, bool _lock)
        {
            this.activityId = activityId;
            this.m_lock = _lock;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)activityId);
            writer.WriteBoolean(m_lock);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            activityId = reader.ReadVarUhShort();
            m_lock = reader.ReadBoolean();
        }
        
    }
    
}