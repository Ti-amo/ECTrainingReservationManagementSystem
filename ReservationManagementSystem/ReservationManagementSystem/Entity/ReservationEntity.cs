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
        /// 予約状態
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 診療大項目
        /// </summary>
        public string MajorExam { get; set; }

        /// <summary>
        /// 診療小項目
        /// </summary>
        public string SubExam { get; set; }
    }
}
