

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristic
    {
        public const short Id = 2983;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public short characteristicId;
        
        public CharacterCharacteristic()
        {
        }
        
        public CharacterCharacteristic(short characteristicId)
        {
            this.characteristicId = characteristicId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort(characteristicId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            characteristicId = reader.ReadShort();
        }
        
    }
    
}