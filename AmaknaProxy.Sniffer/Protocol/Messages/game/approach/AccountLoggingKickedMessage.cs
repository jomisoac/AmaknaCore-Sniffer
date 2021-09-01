

// Generated on 09/01/2021 10:11:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccountLoggingKickedMessage : NetworkMessage
    {
        public const uint Id = 9927;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint days;
        public sbyte hours;
        public sbyte minutes;
        
        public AccountLoggingKickedMessage()
        {
        }
        
        public AccountLoggingKickedMessage(uint days, sbyte hours, sbyte minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)days);
            writer.WriteSbyte(hours);
            writer.WriteSbyte(minutes);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            days = reader.ReadVarUhShort();
            hours = reader.ReadSbyte();
            minutes = reader.ReadSbyte();
        }
        
    }
    
}