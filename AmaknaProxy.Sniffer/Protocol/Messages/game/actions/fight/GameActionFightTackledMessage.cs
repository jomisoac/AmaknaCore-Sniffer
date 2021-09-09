

// Generated on 09/08/2021 14:21:41
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightTackledMessage : AbstractGameActionMessage
    {
        public const uint Id = 5099;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double[] tacklersIds;
        
        public GameActionFightTackledMessage()
        {
        }
        
        public GameActionFightTackledMessage(uint actionId, double sourceId, double[] tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)tacklersIds.Length);
            foreach (var entry in tacklersIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            var limit = (ushort)reader.ReadUShort();
            tacklersIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 tacklersIds[i] = reader.ReadDouble();
            }
        }
        
    }
    
}