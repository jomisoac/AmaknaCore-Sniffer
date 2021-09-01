

// Generated on 09/01/2021 10:12:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayMutantInformations : GameRolePlayHumanoidInformations
    {
        public const short Id = 5654;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint monsterId;
        public sbyte powerLevel;
        
        public GameRolePlayMutantInformations()
        {
        }
        
        public GameRolePlayMutantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, Types.HumanInformations humanoidInfo, int accountId, uint monsterId, sbyte powerLevel)
         : base(contextualId, disposition, look, name, humanoidInfo, accountId)
        {
            this.monsterId = monsterId;
            this.powerLevel = powerLevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)monsterId);
            writer.WriteSbyte(powerLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            monsterId = reader.ReadVarUhShort();
            powerLevel = reader.ReadSbyte();
        }
        
    }
    
}