

// Generated on 08/19/2021 23:34:25
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapChangeOrientationsMessage : NetworkMessage
    {
        public const uint Id = 9267;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ActorOrientation[] orientations;
        
        public GameMapChangeOrientationsMessage()
        {
        }
        
        public GameMapChangeOrientationsMessage(Types.ActorOrientation[] orientations)
        {
            this.orientations = orientations;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)orientations.Length);
            foreach (var entry in orientations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            orientations = new Types.ActorOrientation[limit];
            for (int i = 0; i < limit; i++)
            {
                 orientations[i] = new Types.ActorOrientation();
                 orientations[i].Deserialize(reader);
            }
        }
        
    }
    
}