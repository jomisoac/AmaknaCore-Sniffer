

// Generated on 09/01/2021 10:12:01
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectAveragePricesMessage : NetworkMessage
    {
        public const uint Id = 6792;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] ids;
        public double[] avgPrices;
        
        public ObjectAveragePricesMessage()
        {
        }
        
        public ObjectAveragePricesMessage(uint[] ids, double[] avgPrices)
        {
            this.ids = ids;
            this.avgPrices = avgPrices;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)avgPrices.Length);
            foreach (var entry in avgPrices)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhShort();
            }
            limit = (ushort)reader.ReadUShort();
            avgPrices = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 avgPrices[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}