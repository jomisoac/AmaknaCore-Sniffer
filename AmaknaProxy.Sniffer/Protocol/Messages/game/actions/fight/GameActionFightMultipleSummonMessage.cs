

// Generated on 09/01/2021 10:11:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightMultipleSummonMessage : AbstractGameActionMessage
    {
        public const uint Id = 5219;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GameContextSummonsInformation[] summons;
        
        public GameActionFightMultipleSummonMessage()
        {
        }
        
        public GameActionFightMultipleSummonMessage(uint actionId, double sourceId, Types.GameContextSummonsInformation[] summons)
         : base(actionId, sourceId)
        {
            this.summons = summons;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)summons.Length);
            foreach (var entry in summons)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            summons = new Types.GameContextSummonsInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 summons[i] = ProtocolTypeManager.GetInstance<Types.GameContextSummonsInformation>(reader.ReadUShort());
                 summons[i].Deserialize(reader);
            }
        }
        
    }
    
}