

// Generated on 09/01/2021 10:12:17
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ArenaRankInfos
    {
        public const short Id = 9350;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public Types.ArenaRanking ranking;
        public Types.ArenaLeagueRanking leagueRanking;
        public uint victoryCount;
        public uint fightcount;
        public short numFightNeededForLadder;
        
        public ArenaRankInfos()
        {
        }
        
        public ArenaRankInfos(Types.ArenaRanking ranking, Types.ArenaLeagueRanking leagueRanking, uint victoryCount, uint fightcount, short numFightNeededForLadder)
        {
            this.ranking = ranking;
            this.leagueRanking = leagueRanking;
            this.victoryCount = victoryCount;
            this.fightcount = fightcount;
            this.numFightNeededForLadder = numFightNeededForLadder;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            if (ranking == null)
                writer.WriteByte(0);
            else
            {
                writer.WriteByte(1);
                ranking.Serialize(writer);
            }

            if (leagueRanking == null)
            {
                writer.WriteByte(0);
            }
            else
            {
                writer.WriteByte(1);
                leagueRanking.Serialize(writer);
            }
            writer.WriteVarShort((int)victoryCount);
            writer.WriteVarShort((int)fightcount);
            writer.WriteShort(numFightNeededForLadder);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            var isRankingAvailable = reader.ReadByte();
            if (isRankingAvailable == 1)
            {
                ranking = new ArenaRanking();
                ranking.Deserialize(reader);
            }

            var isLeagueRankingAvailable = reader.ReadByte();
            if (isLeagueRankingAvailable == 1)
            {
                leagueRanking = new ArenaLeagueRanking();
                leagueRanking.Deserialize(reader);
            }
            victoryCount = reader.ReadVarUhShort();
            fightcount = reader.ReadVarUhShort();
            numFightNeededForLadder = reader.ReadShort();
        }
        
    }
    
}