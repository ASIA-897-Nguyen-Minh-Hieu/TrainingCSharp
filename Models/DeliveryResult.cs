using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCSharp.Models
{
    public class DeliveryResult
    {
        public string delivery_cd { get; set; }
        public string delivery_nm { get; set; }
        public string delivery_kn { get; set; }
        public string zip_cd { get; set; }
        public string delivery_addr { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string delivery_class_1 { get; set; }
        public string delivery_class_2 { get; set; }
        public string delivery_class_3 { get; set; }
        public string remark { get; set; }
        public string cre_user { get; set; }
        public string upd_user { get; set; }
    }
}