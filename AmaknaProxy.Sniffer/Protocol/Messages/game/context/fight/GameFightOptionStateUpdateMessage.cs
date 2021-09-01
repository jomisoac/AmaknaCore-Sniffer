

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameFightOptionStateUpdateMessage : NetworkMessage
    {
        public const uint Id = 4364;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint fightId;
        public sbyte teamId;
        public sbyte option;
        public bool state;
        
        public GameFightOptionStateUpdateMessage()
        {
        }
        
        public GameFightOptionStateUpdateMessage(uint fightId, sbyte teamId, sbyte option, bool state)
        {
            this.fightId = fightId;
            this.teamId = teamId;
            this.option = option;
            this.state = state;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort((int)fightId);
            writer.WriteSbyte(teamId);
            writer.WriteSbyte(option);
            writer.WriteBoolean(state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadVarUhShort();
            teamId = reader.ReadSbyte();
            option = reader.ReadSbyte();
            state = reader.ReadBoolean();
        }
        
    }
    
}