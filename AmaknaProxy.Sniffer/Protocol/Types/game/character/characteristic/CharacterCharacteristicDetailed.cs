

// Generated on 09/08/2021 14:22:15
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class CharacterCharacteristicDetailed : CharacterCharacteristic
    {
        public const short Id = 651;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public int @base;
        public int additional;
        public int objectsAndMountBonus;
        public int alignGiftBonus;
        public int contextModif;
        
        public CharacterCharacteristicDetailed()
        {
        }
        
        public CharacterCharacteristicDetailed(short characteristicId, int @base, int additional, int objectsAndMountBonus, int alignGiftBonus, int contextModif)
         : base(characteristicId)
        {
            this.@base = @base;
            this.additional = additional;
            this.objectsAndMountBonus = objectsAndMountBonus;
            this.alignGiftBonus = alignGiftBonus;
            this.contextModif = contextModif;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)@base);
            writer.WriteVarShort((int)additional);
            writer.WriteVarShort((int)objectsAndMountBonus);
            writer.WriteVarShort((int)alignGiftBonus);
            writer.WriteVarShort((int)contextModif);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            @base = reader.ReadVarShort();
            additional = reader.ReadVarShort();
            objectsAndMountBonus = reader.ReadVarShort();
            alignGiftBonus = reader.ReadVarShort();
            contextModif = reader.ReadVarShort();
        }
        
    }
    
}