

// Generated on 09/01/2021 10:11:34
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AcquaintanceServerListMessage : NetworkMessage
    {
        public const uint Id = 6511;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint[] servers;
        
        public AcquaintanceServerListMessage()
        {
        }
        
        public AcquaintanceServerListMessage(uint[] servers)
        {
            this.servers = servers;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)servers.Length);
            foreach (var entry in servers)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            servers = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 servers[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}