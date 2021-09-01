

// Generated on 09/01/2021 10:12:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicsInformations
    {
        public const short Id = 8937;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public double experience;
        public double experienceLevelFloor;
        public double experienceNextLevelFloor;
        public double experienceBonusLimit;
        public double kamas;
        public Types.ActorExtendedAlignmentInformations alignmentInfos;
        public uint criticalHitWeapon;
        public Types.CharacterCharacteristic[] characteristics;
        public Types.CharacterSpellModification[] spellModifications;
        public int probationTime;
        
        public CharacterCharacteristicsInformations()
        {
        }
        
        public CharacterCharacteristicsInformations(double experience, double experienceLevelFloor, double experienceNextLevelFloor, double experienceBonusLimit, double kamas, Types.ActorExtendedAlignmentInformations alignmentInfos, uint criticalHitWeapon, Types.CharacterCharacteristic[] characteristics, Types.CharacterSpellModification[] spellModifications, int probationTime)
        {
            this.experience = experience;
            this.experienceLevelFloor = experienceLevelFloor;
            this.experienceNextLevelFloor = experienceNextLevelFloor;
            this.experienceBonusLimit = experienceBonusLimit;
            this.kamas = kamas;
            this.alignmentInfos = alignmentInfos;
            this.criticalHitWeapon = criticalHitWeapon;
            this.characteristics = characteristics;
            this.spellModifications = spellModifications;
            this.probationTime = probationTime;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(experience);
            writer.WriteVarLong(experienceLevelFloor);
            writer.WriteVarLong(experienceNextLevelFloor);
            writer.WriteVarLong(experienceBonusLimit);
            writer.WriteVarLong(kamas);
            alignmentInfos.Serialize(writer);
            writer.WriteVarShort((int)criticalHitWeapon);
            writer.WriteShort((short)characteristics.Length);
            foreach (var entry in characteristics)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)spellModifications.Length);
            foreach (var entry in spellModifications)
            {
                 entry.Serialize(writer);
            }
            writer.WriteInt(probationTime);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            experience = reader.ReadVarUhLong();
            experienceLevelFloor = reader.ReadVarUhLong();
            experienceNextLevelFloor = reader.ReadVarUhLong();
            experienceBonusLimit = reader.ReadVarUhLong();
            kamas = reader.ReadVarUhLong();
            alignmentInfos = new Types.ActorExtendedAlignmentInformations();
            alignmentInfos.Deserialize(reader);
            criticalHitWeapon = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            characteristics = new Types.CharacterCharacteristic[limit];
            for (int i = 0; i < limit; i++)
            {
                 characteristics[i] = ProtocolTypeManager.GetInstance<Types.CharacterCharacteristic>(reader.ReadUShort());
                 characteristics[i].Deserialize(reader);
            }
            limit = (ushort)reader.ReadUShort();
            spellModifications = new Types.CharacterSpellModification[limit];
            for (int i = 0; i < limit; i++)
            {
                 spellModifications[i] = new Types.CharacterSpellModification();
                 spellModifications[i].Deserialize(reader);
            }
            probationTime = reader.ReadInt();
        }
        
    }
    
}