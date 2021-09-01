

// Generated on 09/01/2021 10:11:40
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class CharacterSelectedSuccessMessage : NetworkMessage
    {
        public const uint Id = 7662;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.CharacterBaseInformations infos;
        public bool isCollectingStats;
        
        public CharacterSelectedSuccessMessage()
        {
        }
        
        public CharacterSelectedSuccessMessage(Types.CharacterBaseInformations infos, bool isCollectingStats)
        {
            this.infos = infos;
            this.isCollectingStats = isCollectingStats;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            infos.Serialize(writer);
            writer.WriteBoolean(isCollectingStats);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            infos = new Types.CharacterBaseInformations();
            infos.Deserialize(reader);
            isCollectingStats = reader.ReadBoolean();
        }
        
    }
    
}