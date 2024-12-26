using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TrainingCSharp.Models;
using TrainingCSharp.Services;

namespace TrainingCSharp.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationDbContext _context;
        public DeliveryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<DeliveryResult> SearchDeliveries(
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
            int type)
        {
            var deliveryCdParam = new SqlParameter("@P_delivery_cd", deliveryCd ?? (object)DBNull.Value);
            var deliveryNmParam = new SqlParameter("@P_delivery_nm", deliveryNm ?? (object)DBNull.Value);
            var deliveryKnParam = new SqlParameter("@P_delivery_kn", deliveryKn ?? (object)DBNull.Value);
            var deliveryAdrParam = new SqlParameter("@P_delivery_adr", deliveryAdr ?? (object)DBNull.Value);
            var deliveryTelParam = new SqlParameter("@P_delivery_tel", deliveryTel ?? (object)DBNull.Value);
            var deliveryClass1Param = new SqlParameter("@P_delivery_class_1", deliveryClass1 ?? (object)DBNull.Value);
            var deliveryClass2Param = new SqlParameter("@P_delivery_class_2", deliveryClass2 ?? (object)DBNull.Value);
            var deliveryClass3Param = new SqlParameter("@P_delivery_class_3", deliveryClass3 ?? (object)DBNull.Value);
            var pageParam = new SqlParameter("@P_page", page);
            var pageSizeParam = new SqlParameter("@P_page_size", pageSize);
            var typeParam = new SqlParameter("@P_type", type);

            return _context.Deliveries
                .FromSqlRaw("EXEC SPC_016_DELIVERY_SEARCH_FND1 @P_delivery_cd, @P_delivery_nm, @P_delivery_kn, @P_delivery_adr, @P_delivery_tel, @P_delivery_class_1, @P_delivery_class_2, @P_delivery_class_3, @P_page, @P_page_size, @P_type",
                    deliveryCdParam,
                    deliveryNmParam,
                    deliveryKnParam,
                    deliveryAdrParam,
                    deliveryTelParam,
                    deliveryClass1Param,
                    deliveryClass2Param,
                    deliveryClass3Param,
                    pageParam,
                    pageSizeParam,
                    typeParam)
                .ToList();
        }
    }
}