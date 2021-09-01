

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristics
    {
        public const short Id = 8957;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.CharacterCharacteristic[] characteristics;
        
        public CharacterCharacteristics()
        {
        }
        
        public CharacterCharacteristics(Types.CharacterCharacteristic[] characteristics)
        {
            this.characteristics = characteristics;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)characteristics.Length);
            foreach (var entry in characteristics)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            characteristics = new Types.CharacterCharacteristic[limit];
            for (int i = 0; i < limit; i++)
            {
                 characteristics[i] = ProtocolTypeManager.GetInstance<Types.CharacterCharacteristic>(reader.ReadUShort());
                 characteristics[i].Deserialize(reader);
            }
        }
        
    }
    
}