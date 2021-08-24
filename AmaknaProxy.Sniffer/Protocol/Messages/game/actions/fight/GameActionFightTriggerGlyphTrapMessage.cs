

// Generated on 08/19/2021 23:34:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
    {
        public const uint Id = 9566;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short markId;
        public uint markImpactCell;
        public double triggeringCharacterId;
        public uint triggeredSpellId;
        
        public GameActionFightTriggerGlyphTrapMessage()
        {
        }
        
        public GameActionFightTriggerGlyphTrapMessage(uint actionId, double sourceId, short markId, uint markImpactCell, double triggeringCharacterId, uint triggeredSpellId)
         : base(actionId, sourceId)
        {
            this.markId = markId;
            this.markImpactCell = markImpactCell;
            this.triggeringCharacterId = triggeringCharacterId;
            this.triggeredSpellId = triggeredSpellId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(markId);
            writer.WriteVarShort((int)markImpactCell);
            writer.WriteDouble(triggeringCharacterId);
            writer.WriteVarShort((int)triggeredSpellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            markId = reader.ReadShort();
            markImpactCell = reader.ReadVarUhShort();
            triggeringCharacterId = reader.ReadDouble();
            triggeredSpellId = reader.ReadVarUhShort();
        }
        
    }
    
}