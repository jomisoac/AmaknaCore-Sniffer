

// Generated on 09/01/2021 10:12:16
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
    {
        public const short Id = 2992;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public sbyte sellType;
        public Types.HumanOption[] options;
        
        public GameRolePlayMerchantInformations()
        {
        }
        
        public GameRolePlayMerchantInformations(double contextualId, Types.EntityDispositionInformations disposition, Types.EntityLook look, string name, sbyte sellType, Types.HumanOption[] options)
         : base(contextualId, disposition, look, name)
        {
            this.sellType = sellType;
            this.options = options;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSbyte(sellType);
            writer.WriteShort((short)options.Length);
            foreach (var entry in options)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            sellType = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            options = new Types.HumanOption[limit];
            for (int i = 0; i < limit; i++)
            {
                 options[i] = ProtocolTypeManager.GetInstance<Types.HumanOption>(reader.ReadUShort());
                 options[i].Deserialize(reader);
            }
        }
        
    }
    
}