

// Generated on 09/01/2021 10:12:08
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PrismFightAddedMessage : NetworkMessage
    {
        public const uint Id = 9746;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.PrismFightersInformation fight;
        
        public PrismFightAddedMessage()
        {
        }
        
        public PrismFightAddedMessage(Types.PrismFightersInformation fight)
        {
            this.fight = fight;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            fight.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fight = new Types.PrismFightersInformation();
            fight.Deserialize(reader);
        }
        
    }
    
}