

// Generated on 09/08/2021 14:21:49
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage
    {
        public const uint Id = 1688;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte actorEventId;
        
        public GameRolePlayShowActorWithEventMessage()
        {
        }
        
        public GameRolePlayShowActorWithEventMessage(Types.GameRolePlayActorInformations informations, sbyte actorEventId)
         : base(informations)
        {
            this.actorEventId = actorEventId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(actorEventId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            actorEventId = reader.ReadSbyte();
        }
        
    }
    
}