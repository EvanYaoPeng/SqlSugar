using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OrmTest.Demo
{
    public class CodeTable
    {
     
        [SugarColumn(IsNullable =false ,IsPrimaryKey =true,IsIdentity =true)]
        public int Id { get; set; }
        [SugarColumn(Length = 21,OldColumnName = "Name2")]
        public string Name{ get; set; }
        [SugarColumn(IsNullable = true,Length =10)]
        public string IsOk { get; set; }
        public Guid Guid { get; set; }
        [SugarColumn(ColumnDataType ="int")]
        public decimal Decimal { get; set; }
        [SugarColumn(IsNullable = true)]
        public DateTime? DateTime { get; set; }
        [SugarColumn(IsNullable = true,OldColumnName = "Dob")]
        public double? Dob2 { get; set; }
        [SugarColumn(Length =110)]
        public string A1 { get; set; }
    }
    public class CodeTable2 {
        public int Id { get; set; }
        public string Name { get; set; }
        [SugarColumn(IsIgnore =true)]
        public string TestId { get; set; }
    }
    public class CodeFirst : DemoBase
    {
        public static void Init()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute 
            });

            //Backup table
            //db.CodeFirst.BackupTable().InitTables(typeof(CodeTable),typeof(CodeTable2));

            //No backup table
            db.CodeFirst.InitTables(typeof(FG_Unit_Report));
            //TODO 现在不能自动增加字段的说明内容 数据库创建表后
        }
    }

    public partial class FG_Unit_Report
    {
        /// <summary>
        /// 主键，自增列
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true, ColumnDescription="ID")]
        public int ID { get; set; }

        /// <summary>
        /// Visit_Id
        /// </summary>
        [SugarColumn(ColumnDescription ="撞单ID")]
        [Description("撞单ID")]
        public int Visit_Id { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [SugarColumn(ColumnDescription = "客户名称")]
        public string UNIT_NAME { get; set; }

        /// <summary>
        /// 客户关键字
        /// </summary>
        public string UNIT_TAGS { get; set; }

        /// <summary>
        /// 客户所属行业类型
        /// </summary>
        public int UNIT_TYPE { get; set; }

        /// <summary>
        /// 客户联系人
        /// </summary>
        public string CONTACTER { get; set; }

        /// <summary>
        /// 客户联系电话
        /// </summary>
        public string TELNo { get; set; }

        /// <summary>
        /// 客户单位地址
        /// </summary>
        public string ADDRESS { get; set; }

        /// <summary>
        /// 客户电子邮件
        /// </summary>
        public string EMAIL { get; set; }

        /// <summary>
        /// 体检负责人姓名
        /// </summary>
        public string CONTACT_NAME { get; set; }

        /// <summary>
        /// 体检负责人电话
        /// </summary>
        public string CONTACT_TELNo { get; set; }

        /// <summary>
        /// 预计体检时间
        /// </summary>
        public DateTime ESTIMATE_CHECK_TIME { get; set; }

        /// <summary>
        /// 预计体检金额
        /// </summary>
        public decimal ESTIMATE_CHECK_AMOUNT { get; set; }

        /// <summary>
        /// 预计成单单价
        /// </summary>
        public decimal ESTIMATE_CHECK_PRICE { get; set; }

        /// <summary>
        /// 预计体检人数
        /// </summary>
        public int ESTIMATE_CHECK_NUMBER { get; set; }

        /// <summary>
        /// 预计落单日期
        /// </summary>
        public DateTime ESTIMATE_ORDER_DATE { get; set; }

        /// <summary>
        /// 以往体检地点
        /// </summary>
        public string PAST_CHECK_PLACE { get; set; }

        /// <summary>
        /// 目前进展
        /// </summary>
        public string PROGRESS { get; set; }

        /// <summary>
        /// 下一步计划
        /// </summary>
        public string NEXT_STEP { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string MEMO { get; set; }

        /// <summary>
        /// 拜访日期
        /// </summary>
        public DateTime VISIT_DATE { get; set; }

        /// <summary>
        /// 初步折扣
        /// </summary>
        public decimal INITIAL_DISCOUNT { get; set; }

        /// <summary>
        /// 销售所属机构编号
        /// </summary>
        public int ORGAN_CODE { get; set; }

        /// <summary>
        /// 销售员工号
        /// </summary>
        public string SALES_CODE { get; set; }

        /// <summary>
        /// 销售员姓名
        /// </summary>
        public string SALES_NAME { get; set; }

        /// <summary>
        /// AUDIT_USER_CODE
        /// </summary>
        public string AUDIT_USER_CODE { get; set; }

        /// <summary>
        /// AUDIT_USER_NAME
        /// </summary>
        public string AUDIT_USER_NAME { get; set; }

        /// <summary>
        /// AUDIT_MEMO
        /// </summary>
        public string AUDIT_MEMO { get; set; }

        /// <summary>
        /// CREATETIME
        /// </summary>
        public DateTime CREATETIME { get; set; }

        /// <summary>
        /// MODIFYTIME
        /// </summary>
        public DateTime MODIFYTIME { get; set; }


    }

    public partial class FG_VISIT_AUDITLOG
    {
        /// <summary>
        /// 主键列，自增
        /// </summary>
        [SugarColumn(IsNullable =false ,IsPrimaryKey =true,IsIdentity =true)]
        public int ID { get; set; }

        /// <summary>
        /// 拜访记录主ID，外联FC_VISIT_RECORD
        /// </summary>
        public int VISIT_ID { get; set; }

        /// <summary>
        /// 审核人工号
        /// </summary>
        public string AUDIT_USER_CODE { get; set; }

        /// <summary>
        /// 审核人姓名
        /// </summary>
        public string AUDIT_USER_NAME { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AUDIT_TIME { get; set; }

        /// <summary>
        /// 审核结果；20-已作废；30-已审核；40-已撞单
        /// </summary>
        public int AUDIT_RESULT { get; set; }

        /// <summary>
        /// 审核说明备注
        /// </summary>
        public string AUDIT_MEMO { get; set; }


    }

    public partial class FG_PerdictCrashVisitId
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 拜访记录Id
        /// </summary>
        public int VisitId { get; set; }

        /// <summary>
        /// LastupdateTime
        /// </summary>
        public DateTime LastupdateTime { get; set; }

        /// <summary>
        /// 1:单位名称 2:关键字 3:联系电话 4:联系地址
        /// </summary>
        public int CrashType { get; set; }

        /// <summary>
        /// 撞单拜访记录id
        /// </summary>
        public int CrashVisitId { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        public DateTime CreateTime { get; set; }


    }

    public partial class FG_Visit_Crash
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 拜访记录主ID
        /// </summary>
        public int VisitID { get; set; }

        /// <summary>
        /// 撞单的拜访记录主ID 用逗号分隔
        /// </summary>
        public string Be_Crashed_id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// CreateUser
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// UpdateUser
        /// </summary>
        public string UpdateUser { get; set; }


    }

    public partial class FG_VISIT_RECORD
    {
        /// <summary>
        /// 主键，自增列
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string UNIT_NAME { get; set; }

        /// <summary>
        /// 客户关键字
        /// </summary>
        public string UNIT_TAGS { get; set; }

        /// <summary>
        /// 客户所属行业类型
        /// </summary>
        public int UNIT_TYPE { get; set; }

        /// <summary>
        /// 客户联系人
        /// </summary>
        public string CONTACTER { get; set; }

        /// <summary>
        /// 客户联系电话
        /// </summary>
        public string TELNo { get; set; }

        /// <summary>
        /// 客户单位地址
        /// </summary>
        public string ADDRESS { get; set; }

        /// <summary>
        /// 客户电子邮件
        /// </summary>
        public string EMAIL { get; set; }

        /// <summary>
        /// 体检负责人姓名
        /// </summary>
        public string CONTACT_NAME { get; set; }

        /// <summary>
        /// 体检负责人电话
        /// </summary>
        public string CONTACT_TELNo { get; set; }

        /// <summary>
        /// 预计体检时间
        /// </summary>
        public DateTime ESTIMATE_CHECK_TIME { get; set; }

        /// <summary>
        /// 预计体检金额
        /// </summary>
        public decimal ESTIMATE_CHECK_AMOUNT { get; set; }

        /// <summary>
        /// 预计成单单价
        /// </summary>
        public decimal ESTIMATE_CHECK_PRICE { get; set; }

        /// <summary>
        /// 预计体检人数
        /// </summary>
        public int ESTIMATE_CHECK_NUMBER { get; set; }

        /// <summary>
        /// 预计落单日期
        /// </summary>
        public DateTime ESTIMATE_ORDER_DATE { get; set; }

        /// <summary>
        /// 以往体检地点
        /// </summary>
        public string PAST_CHECK_PLACE { get; set; }

        /// <summary>
        /// 目前进展
        /// </summary>
        public string PROGRESS { get; set; }

        /// <summary>
        /// 下一步计划
        /// </summary>
        public string NEXT_STEP { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string MEMO { get; set; }

        /// <summary>
        /// 拜访日期
        /// </summary>
        public DateTime VISIT_DATE { get; set; }

        /// <summary>
        /// 初步折扣
        /// </summary>
        public decimal INITIAL_DISCOUNT { get; set; }

        /// <summary>
        /// 销售所属机构编号
        /// </summary>
        public int ORGAN_CODE { get; set; }

        /// <summary>
        /// 销售员工号
        /// </summary>
        public string SALES_CODE { get; set; }

        /// <summary>
        /// 销售员姓名
        /// </summary>
        public string SALES_NAME { get; set; }

        /// <summary>
        /// 记录及审核状态；10-已登记；20-
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 记录创建时间
        /// </summary>
        public DateTime CREATETIME { get; set; }

        /// <summary>
        /// 记录最后一次修改时间
        /// </summary>
        public DateTime MODIFYTIME { get; set; }


    }

    public partial class FG_VISIT_RECORD_DETAIL
    {
        /// <summary>
        /// 主键，自增列
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        /// <summary>
        /// 拜访记录主ID，外联FC_VISIT_REC
        /// </summary>
        public int VISIT_ID { get; set; }

        /// <summary>
        /// 更新内容
        /// </summary>
        public string CONTENT { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime CREATETIME { get; set; }


    }

    public partial class FG_Vist_Auditright
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }

        /// <summary>
        /// 审核人工号
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string AreaCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


    }
}
