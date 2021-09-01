

// Generated on 09/01/2021 10:12:04
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ExchangeObjectTransfertListToInvMessage : NetworkMessage
    {
        public const uint Id = 5580;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] ids;
        
        public ExchangeObjectTransfertListToInvMessage()
        {
        }
        
        public ExchangeObjectTransfertListToInvMessage(uint[] ids)
        {
            this.ids = ids;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)ids.Length);
            foreach (var entry in ids)
            {
                 writer.WriteVarInt((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            ids = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 ids[i] = reader.ReadVarUhInt();
            }
        }
        
    }
    
}