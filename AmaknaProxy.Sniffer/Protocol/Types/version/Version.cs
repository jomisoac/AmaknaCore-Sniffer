

// Generated on 09/01/2021 10:12:21
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class Version
    {
        public const short Id = 9475;
        public virtual short TypeId
        {
            get { return Id; }
        }
        
        public sbyte major;
        public sbyte minor;
        public sbyte code;
        public int build;
        public sbyte buildType;
        
        public Version()
        {
        }
        
        public Version(sbyte major, sbyte minor, sbyte code, int build, sbyte buildType)
        {
            this.major = major;
            this.minor = minor;
            this.code = code;
            this.build = build;
            this.buildType = buildType;
        }
        
        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(major);
            writer.WriteSbyte(minor);
            writer.WriteSbyte(code);
            writer.WriteInt(build);
            writer.WriteSbyte(buildType);
        }
        
        public virtual void Deserialize(IDataReader reader)
        {
            major = reader.ReadSbyte();
            minor = reader.ReadSbyte();
            code = reader.ReadSbyte();
            build = reader.ReadInt();
            buildType = reader.ReadSbyte();
        }
        
    }
    
}