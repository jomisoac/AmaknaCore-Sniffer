

// Generated on 08/19/2021 23:35:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ObjectItemToSellInNpcShop : ObjectItemMinimalInformation
    {
        public const short Id = 3020;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public double objectPrice;
        public string buyCriterion;
        
        public ObjectItemToSellInNpcShop()
        {
        }
        
        public ObjectItemToSellInNpcShop(uint objectGID, Types.ObjectEffect[] effects, double objectPrice, string buyCriterion)
         : base(objectGID, effects)
        {
            this.objectPrice = objectPrice;
            this.buyCriterion = buyCriterion;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(objectPrice);
            writer.WriteUTF(buyCriterion);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            objectPrice = reader.ReadVarUhLong();
            buyCriterion = reader.ReadUTF();
        }
        
    }
    
}