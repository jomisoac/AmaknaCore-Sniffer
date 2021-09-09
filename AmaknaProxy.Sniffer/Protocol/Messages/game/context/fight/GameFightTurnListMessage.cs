

// Generated on 09/08/2021 14:21:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightTurnListMessage : NetworkMessage
    {
        public const uint Id = 3288;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double[] ids;
        public double[] deadsIds;
        
        public GameFightTurnListMessage()
        {
        }
        
        public GameFightTurnListMessage(double[] ids, double[] deadsIds)
        {
            this.ids = ids;
            this.deadsIds = deadsIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteShort((short)deadsIds.Length);
            foreach (var entry in deadsIds)
            {
                 writer.WriteDouble(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            ids = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadDouble();
            }
            limit = (ushort)reader.ReadUShort();
            deadsIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 deadsIds[i] = reader.ReadDouble();
            }
        }
        
    }
    
}