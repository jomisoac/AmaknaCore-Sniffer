

// Generated on 09/08/2021 14:21:54
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
    {
        public const uint Id = 9646;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double mapId;
        public uint elementId;
        
        public LockableStateUpdateStorageMessage()
        {
        }
        
        public LockableStateUpdateStorageMessage(bool locked, double mapId, uint elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(mapId);
            writer.WriteVarInt((int)elementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            mapId = reader.ReadDouble();
            elementId = reader.ReadVarUhInt();
        }
        
    }
    
}