

// Generated on 09/08/2021 14:22:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class SellerBuyerDescriptor
    {
        public const short Id = 5463;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public uint[] quantities;
        public uint[] types;
        public float taxPercentage;
        public float taxModificationPercentage;
        public byte maxItemLevel;
        public uint maxItemPerAccount;
        public int npcContextualId;
        public uint unsoldDelay;
        
        public SellerBuyerDescriptor()
        {
        }
        
        public SellerBuyerDescriptor(uint[] quantities, uint[] types, float taxPercentage, float taxModificationPercentage, byte maxItemLevel, uint maxItemPerAccount, int npcContextualId, uint unsoldDelay)
        {
            this.quantities = quantities;
            this.types = types;
            this.taxPercentage = taxPercentage;
            this.taxModificationPercentage = taxModificationPercentage;
            this.maxItemLevel = maxItemLevel;
            this.maxItemPerAccount = maxItemPerAccount;
            this.npcContextualId = npcContextualId;
            this.unsoldDelay = unsoldDelay;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteShort((short)quantities.Length);
            foreach (var entry in quantities)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)types.Length);
            foreach (var entry in types)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteFloat(taxPercentage);
            writer.WriteFloat(taxModificationPercentage);
            writer.WriteByte(maxItemLevel);
            writer.WriteVarInt((int)maxItemPerAccount);
            writer.WriteInt(npcContextualId);
            writer.WriteVarShort((int)unsoldDelay);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var limit = (ushort)reader.ReadUShort();
            quantities = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 quantities[i] = reader.ReadVarUhInt();
            }
            limit = (ushort)reader.ReadUShort();
            types = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 types[i] = reader.ReadVarUhInt();
            }
            taxPercentage = reader.ReadFloat();
            taxModificationPercentage = reader.ReadFloat();
            maxItemLevel = reader.ReadByte();
            maxItemPerAccount = reader.ReadVarUhInt();
            npcContextualId = reader.ReadInt();
            unsoldDelay = reader.ReadVarUhShort();
        }
        
    }
    
}