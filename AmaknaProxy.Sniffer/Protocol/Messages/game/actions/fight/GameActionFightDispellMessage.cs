

// Generated on 09/08/2021 14:21:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightDispellMessage : AbstractGameActionMessage
    {
        public const uint Id = 3834;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double targetId;
        public bool verboseCast;
        
        public GameActionFightDispellMessage()
        {
        }
        
        public GameActionFightDispellMessage(uint actionId, double sourceId, double targetId, bool verboseCast)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.verboseCast = verboseCast;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(targetId);
            writer.WriteBoolean(verboseCast);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadDouble();
            verboseCast = reader.ReadBoolean();
        }
        
    }
    
}