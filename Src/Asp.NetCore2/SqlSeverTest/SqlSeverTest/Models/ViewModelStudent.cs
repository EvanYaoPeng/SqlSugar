using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmTest.Models
{
    public class ViewModelStudent:Student
    {

    }
    public class ViewModelStudent2
    {
        public string Name { get; set; }
        public Student Student { get; set; }
    }
    public class ViewModelStudent3: Student
    {
         public string SchoolName { get; set; }
    }


    public partial class WF_CARD_RECORD
    {
        public WF_CARD_RECORD()
        {


        }
        /// <summary>
        /// Desc:自增ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int id { get; set; }

        /// <summary>
        /// Desc:卡号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string card_num { get; set; }

        /// <summary>
        /// Desc:使用机构
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string use_organs { get; set; }

        /// <summary>
        /// Desc:卡类别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? card_type { get; set; }

        /// <summary>
        /// Desc:卡品种
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? card_variety { get; set; }

        /// <summary>
        /// Desc:有效期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? closeing_date { get; set; }

        /// <summary>
        /// Desc:结算类别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? pay_type { get; set; }

        /// <summary>
        /// Desc:结算标识
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? pay_mark { get; set; }

        /// <summary>
        /// Desc:卡状态
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? card_status { get; set; }

        /// <summary>
        /// Desc:刊例金额
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? klje { get; set; }

        /// <summary>
        /// Desc:结算金额
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? sfje { get; set; }

        /// <summary>
        /// Desc:套餐数量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? package_quantity { get; set; }

        /// <summary>
        /// Desc:销售员
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string salesman { get; set; }

        /// <summary>
        /// Desc:销售员工号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string salesman_code { get; set; }

        /// <summary>
        /// Desc:单位代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string unit_code { get; set; }

        /// <summary>
        /// Desc:单位名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string unit_name { get; set; }

        /// <summary>
        /// Desc:卡入库编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string flow_num_vault { get; set; }

        /// <summary>
        /// Desc:卡入库机构
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string vault_organ { get; set; }

        /// <summary>
        /// Desc:卡申领编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string flow_num_apply { get; set; }

        /// <summary>
        /// Desc:卡申领明细ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? apply_record_id { get; set; }

        /// <summary>
        /// Desc:预留
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string flow_num_inter { get; set; }

        /// <summary>
        /// Desc:类别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? type { get; set; }

        /// <summary>
        /// Desc:状态
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? status { get; set; }

        /// <summary>
        /// Desc:备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string memo { get; set; }

        /// <summary>
        /// Desc:记录时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? cdate { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string order_num { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CreateTime { get; set; }

    }

}
