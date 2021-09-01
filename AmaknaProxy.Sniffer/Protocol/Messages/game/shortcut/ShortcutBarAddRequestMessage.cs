

// Generated on 09/01/2021 10:12:09
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ShortcutBarAddRequestMessage : NetworkMessage
    {
        public const uint Id = 6092;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte barType;
        public Types.Shortcut shortcut;
        
        public ShortcutBarAddRequestMessage()
        {
        }
        
        public ShortcutBarAddRequestMessage(sbyte barType, Types.Shortcut shortcut)
        {
            this.barType = barType;
            this.shortcut = shortcut;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(barType);
            writer.WriteShort(shortcut.TypeId);
            shortcut.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            barType = reader.ReadSbyte();
            shortcut = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
            shortcut.Deserialize(reader);
        }
        
    }
    
}