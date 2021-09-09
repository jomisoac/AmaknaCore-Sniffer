

// Generated on 09/08/2021 14:21:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ReloginTokenStatusMessage : NetworkMessage
    {
        public const uint Id = 6122;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool validToken;
        public sbyte[] ticket;
        
        public ReloginTokenStatusMessage()
        {
        }
        
        public ReloginTokenStatusMessage(bool validToken, sbyte[] ticket)
        {
            this.validToken = validToken;
            this.ticket = ticket;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(validToken);
            writer.WriteVarInt((int)(ushort)ticket.Length);
            foreach (var entry in ticket)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            validToken = reader.ReadBoolean();
            var limit = (ushort)reader.ReadVarInt();
            ticket = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 ticket[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}