

// Generated on 09/08/2021 14:22:14
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class AchievementAchievedRewardable : AchievementAchieved
    {
        public const short Id = 676;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public uint finishedlevel;
        
        public AchievementAchievedRewardable()
        {
        }
        
        public AchievementAchievedRewardable(uint id, double achievedBy, uint finishedlevel)
         : base(id, achievedBy)
        {
            this.finishedlevel = finishedlevel;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)finishedlevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            finishedlevel = reader.ReadVarUhShort();
        }
        
    }
    
}