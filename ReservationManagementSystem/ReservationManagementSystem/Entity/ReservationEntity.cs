using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagementSystem.Entity {
    public class ReservationEntity {
        /// <summary>
        /// 予約ID
        /// </summary>
        public int ReservationId { get; set; }

        /// <summary>
        /// 予約日付
        /// </summary>
        public string ReservationDate { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientId { get; set; }

        /// <summary>
        /// 患者名
        /// </summary>
        public string PatientName { get; set; }

        /// <summary>
        /// 予約状態ID
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 予約状態名
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// 診療項目
        /// </summary>
        public ExamItem Exam { get; set; }
    }
}
