

// Generated on 09/01/2021 10:12:19
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class HouseInformationsForSell
    {
        public const short Id = 4646;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int instanceId;
        public bool secondHand;
        public uint modelId;
        public Types.AccountTagInformation ownerTag;
        public bool hasOwner;
        public string ownerCharacterName;
        public short worldX;
        public short worldY;
        public uint subAreaId;
        public sbyte nbRoom;
        public sbyte nbChest;
        public int[] skillListIds;
        public bool isLocked;
        public double price;
        
        public HouseInformationsForSell()
        {
        }
        
        public HouseInformationsForSell(int instanceId, bool secondHand, uint modelId, Types.AccountTagInformation ownerTag, bool hasOwner, string ownerCharacterName, short worldX, short worldY, uint subAreaId, sbyte nbRoom, sbyte nbChest, int[] skillListIds, bool isLocked, double price)
        {
            this.instanceId = instanceId;
            this.secondHand = secondHand;
            this.modelId = modelId;
            this.ownerTag = ownerTag;
            this.hasOwner = hasOwner;
            this.ownerCharacterName = ownerCharacterName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.nbRoom = nbRoom;
            this.nbChest = nbChest;
            this.skillListIds = skillListIds;
            this.isLocked = isLocked;
            this.price = price;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(instanceId);
            writer.WriteBoolean(secondHand);
            writer.WriteVarInt((int)modelId);
            ownerTag.Serialize(writer);
            writer.WriteBoolean(hasOwner);
            writer.WriteUTF(ownerCharacterName);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteVarShort((int)subAreaId);
            writer.WriteSbyte(nbRoom);
            writer.WriteSbyte(nbChest);
            writer.WriteShort((short)skillListIds.Length);
            foreach (var entry in skillListIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteBoolean(isLocked);
            writer.WriteVarLong(price);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            instanceId = reader.ReadInt();
            secondHand = reader.ReadBoolean();
            modelId = reader.ReadVarUhInt();
            ownerTag = new Types.AccountTagInformation();
            ownerTag.Deserialize(reader);
            hasOwner = reader.ReadBoolean();
            ownerCharacterName = reader.ReadUTF();
            worldX = reader.ReadShort();
            worldY = reader.ReadShort();
            subAreaId = reader.ReadVarUhShort();
            nbRoom = reader.ReadSbyte();
            nbChest = reader.ReadSbyte();
            var limit = (ushort)reader.ReadUShort();
            skillListIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 skillListIds[i] = reader.ReadInt();
            }
            isLocked = reader.ReadBoolean();
            price = reader.ReadVarUhLong();
        }
        
    }
    
}