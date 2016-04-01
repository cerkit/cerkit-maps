using System;
using System.Runtime.Serialization;

namespace cerkitMaps.Models
{
    [DataContract]
    public class MapShapeViewModel
    {
        private byte[] _shapeBytes;

        public byte[] ShapeBytes
        {
            get { return _shapeBytes; }
            set { _shapeBytes = value; }
        }

        private byte[] _dbfBytes;

        public byte[] DbfBytes
        {
            get { return _dbfBytes; }
            set { _dbfBytes = value; }
        }

        [DataMember(Name = "shape", Order = 0)]
        public string Shape {
            get { return Convert.ToBase64String(_shapeBytes); }
            set { _shapeBytes = Convert.FromBase64String(value); }
        }

        [DataMember(Name = "dbf", Order = 1)]
        public string Dbf
        {
            get { return Convert.ToBase64String(_dbfBytes); }
            set { _dbfBytes = Convert.FromBase64String(value);  }
        }
    }
}