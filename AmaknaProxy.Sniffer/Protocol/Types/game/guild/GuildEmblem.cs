

// Generated on 09/08/2021 14:22:20
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GuildEmblem
    {
        public const short Id = 150;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint symbolShape;
        public int symbolColor;
        public sbyte backgroundShape;
        public int backgroundColor;
        
        public GuildEmblem()
        {
        }
        
        public GuildEmblem(uint symbolShape, int symbolColor, sbyte backgroundShape, int backgroundColor)
        {
            this.symbolShape = symbolShape;
            this.symbolColor = symbolColor;
            this.backgroundShape = backgroundShape;
            this.backgroundColor = backgroundColor;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)symbolShape);
            writer.WriteInt(symbolColor);
            writer.WriteSbyte(backgroundShape);
            writer.WriteInt(backgroundColor);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            symbolShape = reader.ReadVarUhShort();
            symbolColor = reader.ReadInt();
            backgroundShape = reader.ReadSbyte();
            backgroundColor = reader.ReadInt();
        }
        
    }
    
}