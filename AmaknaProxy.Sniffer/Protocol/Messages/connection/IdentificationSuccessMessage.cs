

// Generated on 08/19/2021 23:34:13
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class IdentificationSuccessMessage : NetworkMessage
    {
        public const uint Id = 7272;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool hasRights;
        public bool hasConsoleRight;
        public bool wasAlreadyConnected;
        public string login;
        public Types.AccountTagInformation accountTag;
        public int accountId;
        public sbyte communityId;
        public string secretQuestion;
        public double accountCreation;
        public double subscriptionElapsedDuration;
        public double subscriptionEndDate;
        public byte havenbagAvailableRoom;
        
        public IdentificationSuccessMessage()
        {
        }
        
        public IdentificationSuccessMessage(bool hasRights, bool hasConsoleRight, bool wasAlreadyConnected, string login, Types.AccountTagInformation accountTag, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom)
        {
            this.hasRights = hasRights;
            this.hasConsoleRight = hasConsoleRight;
            this.wasAlreadyConnected = wasAlreadyConnected;
            this.login = login;
            this.accountTag = accountTag;
            this.accountId = accountId;
            this.communityId = communityId;
            this.secretQuestion = secretQuestion;
            this.accountCreation = accountCreation;
            this.subscriptionElapsedDuration = subscriptionElapsedDuration;
            this.subscriptionEndDate = subscriptionEndDate;
            this.havenbagAvailableRoom = havenbagAvailableRoom;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, hasRights);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, hasConsoleRight);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, wasAlreadyConnected);
            writer.WriteByte(flag1);
            writer.WriteUTF(login);
            accountTag.Serialize(writer);
            writer.WriteInt(accountId);
            writer.WriteSbyte(communityId);
            writer.WriteUTF(secretQuestion);
            writer.WriteDouble(accountCreation);
            writer.WriteDouble(subscriptionElapsedDuration);
            writer.WriteDouble(subscriptionEndDate);
            writer.WriteByte(havenbagAvailableRoom);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag1 = reader.ReadByte();
            hasRights = BooleanByteWrapper.GetFlag(flag1, 0);
            hasConsoleRight = BooleanByteWrapper.GetFlag(flag1, 1);
            wasAlreadyConnected = BooleanByteWrapper.GetFlag(flag1, 2);
            login = reader.ReadUTF();
            accountTag = new Types.AccountTagInformation();
            accountTag.Deserialize(reader);
            accountId = reader.ReadInt();
            communityId = reader.ReadSbyte();
            secretQuestion = reader.ReadUTF();
            accountCreation = reader.ReadDouble();
            subscriptionElapsedDuration = reader.ReadDouble();
            subscriptionEndDate = reader.ReadDouble();
            havenbagAvailableRoom = reader.ReadByte();
        }
        
    }
    
}