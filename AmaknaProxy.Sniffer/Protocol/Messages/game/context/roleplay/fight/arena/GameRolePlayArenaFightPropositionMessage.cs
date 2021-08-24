

// Generated on 08/19/2021 23:34:31
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
    {
        public const uint Id = 6895;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public double[] alliesId;
        public uint duration;
        
        public GameRolePlayArenaFightPropositionMessage()
        {
        }
        
        public GameRolePlayArenaFightPropositionMessage(uint fightId, double[] alliesId, uint duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)fightId);
            writer.WriteShort((short)alliesId.Length);
            foreach (var entry in alliesId)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteVarShort((int)duration);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUhShort();
            var limit = (ushort)reader.ReadUShort();
            alliesId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 alliesId[i] = reader.ReadDouble();
            }
            duration = reader.ReadVarUhShort();
        }
        
    }
    
}