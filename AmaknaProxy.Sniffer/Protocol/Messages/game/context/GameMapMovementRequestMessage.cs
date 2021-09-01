

// Generated on 09/01/2021 10:11:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GameMapMovementRequestMessage : NetworkMessage
    {
        public const uint Id = 1780;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public short[] keyMovements;
        public double mapId;
        
        public GameMapMovementRequestMessage()
        {
        }
        
        public GameMapMovementRequestMessage(short[] keyMovements, double mapId)
        {
            this.keyMovements = keyMovements;
            this.mapId = mapId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)keyMovements.Length);
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteDouble(mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 keyMovements[i] = reader.ReadShort();
            }
            mapId = reader.ReadDouble();
        }
        
    }
    
}