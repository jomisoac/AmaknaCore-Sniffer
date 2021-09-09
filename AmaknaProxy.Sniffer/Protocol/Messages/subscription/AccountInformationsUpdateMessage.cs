

// Generated on 09/08/2021 14:22:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class AccountInformationsUpdateMessage : NetworkMessage
    {
        public const uint Id = 1933;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double subscriptionEndDate;
        
        public AccountInformationsUpdateMessage()
        {
        }
        
        public AccountInformationsUpdateMessage(double subscriptionEndDate)
        {
            this.subscriptionEndDate = subscriptionEndDate;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(subscriptionEndDate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            subscriptionEndDate = reader.ReadDouble();
        }
        
    }
    
}