

// Generated on 09/08/2021 14:21:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class SelectedServerRefusedMessage : NetworkMessage
    {
        public const uint Id = 506;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint serverId;
        public sbyte error;
        public sbyte serverStatus;
        
        public SelectedServerRefusedMessage()
        {
        }
        
        public SelectedServerRefusedMessage(uint serverId, sbyte error, sbyte serverStatus)
        {
            this.serverId = serverId;
            this.error = error;
            this.serverStatus = serverStatus;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)serverId);
            writer.WriteSbyte(error);
            writer.WriteSbyte(serverStatus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            serverId = reader.ReadVarUhShort();
            error = reader.ReadSbyte();
            serverStatus = reader.ReadSbyte();
        }
        
    }
    
}