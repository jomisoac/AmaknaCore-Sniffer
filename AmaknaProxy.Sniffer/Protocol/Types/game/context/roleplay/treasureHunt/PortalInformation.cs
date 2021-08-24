

// Generated on 08/19/2021 23:35:05
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class PortalInformation
    {
        public const short Id = 2566;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public int portalId;
        public short areaId;
        
        public PortalInformation()
        {
        }
        
        public PortalInformation(int portalId, short areaId)
        {
            this.portalId = portalId;
            this.areaId = areaId;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteInt(portalId);
            writer.WriteShort(areaId);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            portalId = reader.ReadInt();
            areaId = reader.ReadShort();
        }
        
    }
    
}