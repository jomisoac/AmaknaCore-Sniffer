

// Generated on 09/01/2021 10:11:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class DocumentReadingBeginMessage : NetworkMessage
    {
        public const uint Id = 7475;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint documentId;
        
        public DocumentReadingBeginMessage()
        {
        }
        
        public DocumentReadingBeginMessage(uint documentId)
        {
            this.documentId = documentId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)documentId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            documentId = reader.ReadVarUhShort();
        }
        
    }
    
}