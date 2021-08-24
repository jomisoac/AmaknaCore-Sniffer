

// Generated on 08/19/2021 23:34:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MigratedServerListMessage : NetworkMessage
    {
        public const uint Id = 1829;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] migratedServerIds;
        
        public MigratedServerListMessage()
        {
        }
        
        public MigratedServerListMessage(uint[] migratedServerIds)
        {
            this.migratedServerIds = migratedServerIds;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)migratedServerIds.Length);
            foreach (var entry in migratedServerIds)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            migratedServerIds = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 migratedServerIds[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}