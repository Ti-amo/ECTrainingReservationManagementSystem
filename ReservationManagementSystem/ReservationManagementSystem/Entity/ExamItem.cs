using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagementSystem.Entity
{
    public class ExamItem
    {
        /// <summary>
        /// 診療大項目ID
        /// </summary>
        public int MajorExamId { get; set; }

        /// <summary>
        /// 診療大項目名
        /// </summary>
        public string MajorExamName { get; set; }

        /// <summary>
        /// 診療大項目の日本語名
        /// </summary>
        public string MajorExamNameJp { get; set; }

        /// <summary>
        /// 診療大項目の英語名
        /// </summary>
        public string MajorExamNameEn { get; set; }

        /// <summary>
        /// 診療小項目ID
        /// </summary>
        public int SubExamId { get; set; }

        /// <summary>
        /// 診療小項目名
        /// </summary>
        public string SubExamName { get; set; }

        /// <summary>
        /// 診療小項目の日本語名
        /// </summary>
        public string SubExamNameJp { get; set; }

        /// <summary>
        /// 診療小項目の英語名
        /// </summary>
        public string SubExamNameEn { get; set; }
    }
}