

// Generated on 09/01/2021 10:12:10
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class TrustStatusMessage : NetworkMessage
    {
        public const uint Id = 2797;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool trusted;
        public bool certified;
        
        public TrustStatusMessage()
        {
        }
        
        public TrustStatusMessage(bool trusted, bool certified)
        {
            this.trusted = trusted;
            this.certified = certified;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, trusted);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, certified);
            writer.WriteByte(flag1);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            trusted = BooleanByteWrapper.GetFlag(flag1, 0);
            certified = BooleanByteWrapper.GetFlag(flag1, 1);
        }
        
    }
    
}