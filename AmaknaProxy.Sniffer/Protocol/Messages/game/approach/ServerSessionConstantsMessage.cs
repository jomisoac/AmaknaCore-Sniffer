

// Generated on 09/08/2021 14:21:43
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class ServerSessionConstantsMessage : NetworkMessage
    {
        public const uint Id = 20;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.ServerSessionConstant[] variables;
        
        public ServerSessionConstantsMessage()
        {
        }
        
        public ServerSessionConstantsMessage(Types.ServerSessionConstant[] variables)
        {
            this.variables = variables;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)variables.Length);
            foreach (var entry in variables)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            variables = new Types.ServerSessionConstant[limit];
            for (int i = 0; i < limit; i++)
            {
                 variables[i] = ProtocolTypeManager.GetInstance<Types.ServerSessionConstant>(reader.ReadUShort());
                 variables[i].Deserialize(reader);
            }
        }
        
    }
    
}