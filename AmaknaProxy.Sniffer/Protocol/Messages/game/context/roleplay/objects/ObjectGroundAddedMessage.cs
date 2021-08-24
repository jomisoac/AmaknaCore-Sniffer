

// Generated on 08/19/2021 23:34:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ObjectGroundAddedMessage : NetworkMessage
    {
        public const uint Id = 9392;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint cellId;
        public uint objectGID;
        
        public ObjectGroundAddedMessage()
        {
        }
        
        public ObjectGroundAddedMessage(uint cellId, uint objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)cellId);
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}