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
    [Entity(TableCnName = "子场景", TableName = "Gfm_bim_model_effective_main", DetailTable = new Type[] { typeof(ModelEffectiveDetail) }, DetailTableCnName = "行为列表")]
    [Table("Gfm_bim_model_effective_main")]
    public class MainModel : BaseEntity
    {
        /// <summary>
        ///模型
        /// </summary>
        [Display(Name = "模型")]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        [Editable(true)]
        public string MODEL_ID { get; set; }

        /// <summary>
        ///项目
        /// </summary>
        [Display(Name = "项目")]
        [Column(TypeName = "int")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public int PROJECT_ID { get; set; }

        /// <summary>
        ///页面菜单
        /// </summary>
        [Display(Name = "页面菜单")]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public string REFER_KEY { get; set; }

        /// <summary>
        ///子场景描述
        /// </summary>
        [Display(Name = "子场景描述")]
        [MaxLength(1024)]
        [Column(TypeName = "nvarchar(1024)")]
        [Editable(true)]
        public string DESCRIPTION { get; set; }

        /// <summary>
        ///模型类型
        /// </summary>
        [Display(Name = "模型类型")]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        [Editable(true)]
        public string MODEL_TYPE { get; set; }

        /// <summary>
        ///楼层
        /// </summary>
        [Display(Name = "楼层")]
        [MaxLength(10)]
        [Column(TypeName = "nvarchar(10)")]
        [Editable(true)]
        public string FLOOR { get; set; }

        /// <summary>
        ///效果范围
        /// </summary>
        [Display(Name = "效果范围")]
        [Column(TypeName = "short")]
        [Editable(true)]
        public short? EFFECTIVE_TYPE { get; set; }

        /// <summary>
        ///轮廓线
        /// </summary>
        [Display(Name = "轮廓线")]
        [Column(TypeName = "short")]
        [Editable(true)]
        public short? BORDER_ENABLE { get; set; }

        /// <summary>
        ///阴影
        /// </summary>
        [Display(Name = "阴影")]
        [Column(TypeName = "short")]
        [Editable(true)]
        public short? SHADOW_ENABLE { get; set; }

        /// <summary>
        ///有效标识
        /// </summary>
        [Display(Name = "有效标识")]
        [Column(TypeName = "short")]
        [Editable(true)]
        public short? ENABLE_FLAG { get; set; }

        /// <summary>
        ///相机位
        /// </summary>
        [Display(Name = "相机位")]
        [MaxLength(4000)]
        [Column(TypeName = "nvarchar(4000)")]
        [Editable(true)]
        public string CAMERA { get; set; }

        /// <summary>
        ///创建人
        /// </summary>
        [Display(Name = "创建人")]
        [JsonIgnore]
        [Column(TypeName = "int")]
        public int? CREATE_STAFF_ID { get; set; }

        /// <summary>
        ///创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [JsonIgnore]
        [Column(TypeName = "datetime")]
        public DateTime? CREATE_TIME { get; set; }

        /// <summary>
        ///MAIN_ID
        /// </summary>
        [Key]
        [Display(Name = "MAIN_ID")]
        [Column(TypeName = "int")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public int MAIN_ID { get; set; }

        /// <summary>
        ///修改人
        /// </summary>
        [Display(Name = "修改人")]
        [JsonIgnore]
        [Column(TypeName = "int")]
        public int? MODIFY_STAFF_ID { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        [JsonIgnore]
        [Column(TypeName = "datetime")]
        public DateTime? MODIFY_TIME { get; set; }

        /// <summary>
        ///系统编码
        /// </summary>
        [Display(Name = "系统编码")]
        [MaxLength(25)]
        [JsonIgnore]
        [Column(TypeName = "nvarchar(25)")]
        public string SYSTEM_CODE { get; set; }

        [Display(Name = "行为列表")]
        [ForeignKey("MAIN_ID")]
        public List<ModelEffectiveDetail> ModelEffectiveDetail { get; set; }

    }
}
