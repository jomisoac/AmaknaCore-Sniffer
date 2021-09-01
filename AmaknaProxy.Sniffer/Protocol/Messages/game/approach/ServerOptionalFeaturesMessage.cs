

// Generated on 09/01/2021 10:11:38
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerOptionalFeaturesMessage : NetworkMessage
    {
        public const uint Id = 4257;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte[] features;
        
        public ServerOptionalFeaturesMessage()
        {
        }
        
        public ServerOptionalFeaturesMessage(sbyte[] features)
        {
            this.features = features;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)(ushort)features.Length);
            foreach (var entry in features)
            {
                 writer.WriteSbyte(entry);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadVarInt();
            features = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 features[i] = reader.ReadSbyte();
            }
        }
        
    }
    
}