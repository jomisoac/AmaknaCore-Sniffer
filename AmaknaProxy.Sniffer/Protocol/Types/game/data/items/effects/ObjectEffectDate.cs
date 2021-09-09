

// Generated on 09/08/2021 14:22:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectEffectDate : ObjectEffect
    {
        public const short Id = 6498;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint year;
        public sbyte month;
        public sbyte day;
        public sbyte hour;
        public sbyte minute;
        
        public ObjectEffectDate()
        {
        }
        
        public ObjectEffectDate(uint actionId, uint year, sbyte month, sbyte day, sbyte hour, sbyte minute)
         : base(actionId)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.minute = minute;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)year);
            writer.WriteSbyte(month);
            writer.WriteSbyte(day);
            writer.WriteSbyte(hour);
            writer.WriteSbyte(minute);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            year = reader.ReadVarUhShort();
            month = reader.ReadSbyte();
            day = reader.ReadSbyte();
            hour = reader.ReadSbyte();
            minute = reader.ReadSbyte();
        }
        
    }
    
}