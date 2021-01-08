using Newtonsoft.Json;
/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "项目列表",TableName = "T_project")]
    [Table("T_project")]
    public class ProjectList:BaseEntity
    {
        /// <summary>
       ///项目名称
       /// </summary>
       [Display(Name ="项目名称")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string NAME { get; set; }

       /// <summary>
       ///编码
       /// </summary>
       [Display(Name ="编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string CODE { get; set; }

       /// <summary>
       ///BIM项目
       /// </summary>
       [Display(Name ="BIM项目")]
       [Column(TypeName="int")]
       public int? BIM_FLAG { get; set; }

       /// <summary>
       ///开始时间
       /// </summary>
       [Display(Name ="开始时间")]
       [Column(TypeName="datetime")]
       public DateTime? START_TIME { get; set; }

       /// <summary>
       ///结束时间
       /// </summary>
       [Display(Name ="结束时间")]
       [Column(TypeName="datetime")]
       public DateTime? END_TIME { get; set; }

       /// <summary>
       ///经度
       /// </summary>
       [Display(Name ="经度")]
       [Column(TypeName="int")]
       public int? LAT { get; set; }

       /// <summary>
       ///纬度
       /// </summary>
       [Display(Name ="纬度")]
       [Column(TypeName="int")]
       public int? LNG { get; set; }

       /// <summary>
       ///状态
       /// </summary>
       [Display(Name ="状态")]
       [Column(TypeName="int")]
       public int? STATUS { get; set; }

       /// <summary>
       ///模板
       /// </summary>
       [Display(Name ="模板")]
       [Column(TypeName="int")]
       public int? TPL_ID { get; set; }

       /// <summary>
       ///项目编码
       /// </summary>
       [Display(Name ="项目编码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string PROJECT_CODE { get; set; }

       /// <summary>
       ///有效标识
       /// </summary>
       [Display(Name ="有效标识")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? ACTIVE_FLAG { get; set; }

       /// <summary>
       ///地址
       /// </summary>
       [Display(Name ="地址")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       public string ADDRESS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AREA_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? AREA_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CREATE_STAFF_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? CREATE_STAFF_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CREATE_TIME")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? CREATE_TIME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MAIN_DEP_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? MAIN_DEP_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MGM_DEP_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? MGM_DEP_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MODIFY_STAFF_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? MODIFY_STAFF_ID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="MODIFY_TIME")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? MODIFY_TIME { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NEW_FLAG")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? NEW_FLAG { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OWN_DEP_ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? OWN_DEP_ID { get; set; }

       /// <summary>
       ///照片
       /// </summary>
       [Display(Name ="照片")]
       [MaxLength(200)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(200)")]
       public string PHOTO { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PROP_TYPE")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? PROP_TYPE { get; set; }

       
    }
}
