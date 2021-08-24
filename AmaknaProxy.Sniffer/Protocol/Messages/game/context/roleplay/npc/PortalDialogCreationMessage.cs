

// Generated on 08/19/2021 23:34:35
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PortalDialogCreationMessage : NpcDialogCreationMessage
    {
        public const uint Id = 3236;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int type;
        
        public PortalDialogCreationMessage()
        {
        }
        
        public PortalDialogCreationMessage(double mapId, int npcId, int type)
         : base(mapId, npcId)
        {
            this.type = type;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            type = reader.ReadInt();
        }
        
    }
    
}