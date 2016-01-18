using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustReliefDataAccess.DataObject
{

    public class category
    {
        public int CGID { get; set; }

        public string CGCode { get; set; }
        public int CGParentID { get; set; }
        public string CGName { get; set; }
        public string CGSmallImage { get; set; }
        public string CGLargeImage { get; set; }
        public string CGDescription { get; set; }
        public int Sequence { get; set; }
        public int CGLevel { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
