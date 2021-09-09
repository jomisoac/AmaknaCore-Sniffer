

// Generated on 09/08/2021 14:22:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicValue : CharacterCharacteristic
    {
        public const short Id = 4252;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int total;
        
        public CharacterCharacteristicValue()
        {
        }
        
        public CharacterCharacteristicValue(short characteristicId, int total)
         : base(characteristicId)
        {
            this.total = total;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(total);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            total = reader.ReadInt();
        }
        
    }
    
}