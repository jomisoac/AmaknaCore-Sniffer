

// Generated on 09/01/2021 10:12:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AlternativeMonstersInGroupLightInformations
    {
        public const short Id = 6668;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int playerCount;
        public Types.MonsterInGroupLightInformations[] monsters;
        
        public AlternativeMonstersInGroupLightInformations()
        {
        }
        
        public AlternativeMonstersInGroupLightInformations(int playerCount, Types.MonsterInGroupLightInformations[] monsters)
        {
            this.playerCount = playerCount;
            this.monsters = monsters;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(playerCount);
            writer.WriteShort((short)monsters.Length);
            foreach (var entry in monsters)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            playerCount = reader.ReadInt();
            var limit = (ushort)reader.ReadUShort();
            monsters = new Types.MonsterInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsters[i] = new Types.MonsterInGroupLightInformations();
                 monsters[i].Deserialize(reader);
            }
        }
        
    }
    
}