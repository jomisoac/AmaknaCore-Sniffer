

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HavenBagRoomPreviewInformation
    {
        public const short Id = 5660;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public byte roomId;
        public sbyte themeId;
        
        public HavenBagRoomPreviewInformation()
        {
        }
        
        public HavenBagRoomPreviewInformation(byte roomId, sbyte themeId)
        {
            this.roomId = roomId;
            this.themeId = themeId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteByte(roomId);
            writer.WriteSbyte(themeId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            roomId = reader.ReadByte();
            themeId = reader.ReadSbyte();
        }
        
    }
    
}