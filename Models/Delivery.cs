using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingCSharp.Models
{
    public class Delivery
    {
        public string delivery_cd { get; set; }
        public string delivery_nm1 { get; set; }
        public string delivery_nm2 { get; set; }
        public string sch_delivery_nm { get; set; }
        public string delivery_kn1 { get; set; }
        public string delivery_kn2 { get; set; }
        public string zip_cd { get; set; }
        public string prefecture_cd { get; set; }
        public string city_nm { get; set; }
        public string town_nm { get; set; }
        public string apartment_nm { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string delivery_class_1 { get; set; }
        public string delivery_class_2 { get; set; }
        public string delivery_class_3 { get; set; }
        public string remark { get; set; }
        public string memo { get; set; }
        public string cre_user { get; set; }
        public string cre_prg { get; set; }
        public string cre_ip { get; set; }
        public DateTime cre_date { get; set; }
        public string upd_user { get; set; }
        public string upd_prg { get; set; }
        public string upd_ip { get; set; }
        public DateTime upd_date { get; set; }
        public string del_user { get; set; }
        public string del_prg { get; set; }
        public string del_ip { get; set; }
        public DateTime del_date { get; set; }
        public int del_flg { get; set; }
    }
}