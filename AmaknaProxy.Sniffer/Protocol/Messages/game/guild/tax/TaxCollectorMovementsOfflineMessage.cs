

// Generated on 08/19/2021 23:34:44
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TaxCollectorMovementsOfflineMessage : NetworkMessage
    {
        public const uint Id = 1715;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public Types.TaxCollectorMovement[] movements;
        
        public TaxCollectorMovementsOfflineMessage()
        {
        }
        
        public TaxCollectorMovementsOfflineMessage(Types.TaxCollectorMovement[] movements)
        {
            this.movements = movements;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)movements.Length);
            foreach (var entry in movements)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            movements = new Types.TaxCollectorMovement[limit];
            for (int i = 0; i < limit; i++)
            {
                 movements[i] = new Types.TaxCollectorMovement();
                 movements[i].Deserialize(reader);
            }
        }
        
    }
    
}