using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCSharp.Models;

namespace TrainingCSharp.Repositories
{
    public interface IDeliveryRepository
    {
         List<DeliveryResult> SearchDeliveries(  
            string deliveryCd,
            string deliveryNm,
            string deliveryKn,
            string deliveryAdr,
            string deliveryTel,
            string deliveryClass1,
            string deliveryClass2,
            string deliveryClass3,
            int page,
            int pageSize,
            int type);
    }
}