

// Generated on 09/08/2021 14:22:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class FightLoot
    {
        public const short Id = 1098;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint[] objects;
        public double kamas;
        
        public FightLoot()
        {
        }
        
        public FightLoot(uint[] objects, double kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)objects.Length);
            foreach (var entry in objects)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteVarLong(kamas);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            objects = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = reader.ReadVarUhInt();
            }
            kamas = reader.ReadVarUhLong();
        }
        
    }
    
}