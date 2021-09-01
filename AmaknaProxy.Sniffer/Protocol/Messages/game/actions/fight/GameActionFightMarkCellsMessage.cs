

// Generated on 09/01/2021 10:11:36
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameActionFightMarkCellsMessage : AbstractGameActionMessage
    {
        public const uint Id = 3605;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.GameActionMark mark;
        
        public GameActionFightMarkCellsMessage()
        {
        }
        
        public GameActionFightMarkCellsMessage(uint actionId, double sourceId, Types.GameActionMark mark)
         : base(actionId, sourceId)
        {
            this.mark = mark;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            mark.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            mark = new Types.GameActionMark();
            mark.Deserialize(reader);
        }
        
    }
    
}