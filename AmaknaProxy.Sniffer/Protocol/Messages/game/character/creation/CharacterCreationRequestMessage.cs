

// Generated on 09/01/2021 10:11:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterCreationRequestMessage : NetworkMessage
    {
        public const uint Id = 9213;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public string name;
        public sbyte breed;
        public bool sex;
        public int[] colors;
        public uint cosmeticId;
        
        public CharacterCreationRequestMessage()
        {
        }
        
        public CharacterCreationRequestMessage(string name, sbyte breed, bool sex, int[] colors, uint cosmeticId)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.colors = colors;
            this.cosmeticId = cosmeticId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteSbyte(breed);
            writer.WriteBoolean(sex);
            writer.WriteShort((short)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarShort((int)cosmeticId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            name = reader.ReadUTF();
            breed = reader.ReadSbyte();
            sex = reader.ReadBoolean();
            var limit = (ushort)reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            cosmeticId = reader.ReadVarUhShort();
        }
        
    }
    
}