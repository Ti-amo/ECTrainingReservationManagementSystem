using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagementSystem.Entity
{
    public class PatientEntity
    {
        /// <summary>
        /// 患者ID
        /// </summary>
        public string PatientId { get; set; }
        /// <summary>
        /// 患者名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 生年月日
        /// </summary>
        public string BirthDate { get; set; }
        /// <summary>
        /// 患者の予約リスト
        /// </summary>
        public List<ReservationEntity> Reservation { get; set; }
    }
}
