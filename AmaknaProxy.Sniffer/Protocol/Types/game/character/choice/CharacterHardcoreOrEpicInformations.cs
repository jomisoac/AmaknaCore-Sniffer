

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
    {
        public const short Id = 9632;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte deathState;
        public uint deathCount;
        public uint deathMaxLevel;
        
        public CharacterHardcoreOrEpicInformations()
        {
        }
        
        public CharacterHardcoreOrEpicInformations(double id, string name, uint level, Types.EntityLook entityLook, sbyte breed, bool sex, sbyte deathState, uint deathCount, uint deathMaxLevel)
         : base(id, name, level, entityLook, breed, sex)
        {
            this.deathState = deathState;
            this.deathCount = deathCount;
            this.deathMaxLevel = deathMaxLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(deathState);
            writer.WriteVarShort((int)deathCount);
            writer.WriteVarShort((int)deathMaxLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            deathState = reader.ReadSbyte();
            deathCount = reader.ReadVarUhShort();
            deathMaxLevel = reader.ReadVarUhShort();
        }
        
    }
    
}