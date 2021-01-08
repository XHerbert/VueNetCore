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
    [Entity(TableCnName = "场景配置", TableName = "gfm_bim_model_effective_main")]
    [Table("gfm_bim_model_effective_main")]
    public class mainModelEffective : BaseEntity
    {
        /// <summary>
        ///项目
        /// </summary>
        [Display(Name = "项目")]
        [Column(TypeName = "int")]
        [Editable(true)]
        [Required(AllowEmptyStrings = false)]
        public int PROJECT_ID { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Key]
        [Display(Name = "Id")]
        [Column(TypeName = "int")]
        [Required(AllowEmptyStrings = false)]
        public int Id { get; set; }

        /// <summary>
        ///创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }

        /// <summary>
        ///模型
        /// </summary>
        [Display(Name = "模型")]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        [Editable(true)]
        public string MODEL_ID { get; set; }

        /// <summary>
        ///创建人
        /// </summary>
        [Display(Name = "创建人")]
        [Column(TypeName = "int")]
        public int? CreateID { get; set; }

        /// <summary>
        ///是否有效
        /// </summary>
        [Display(Name = "是否有效")]
        [Column(TypeName = "int")]
        public int? Enable { get; set; }

        /// <summary>
        ///模型类型
        /// </summary>
        [Display(Name = "模型类型")]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        [Editable(true)]
        public string MODEL_TYPE { get; set; }

        /// <summary>
        ///楼层
        /// </summary>
        [Display(Name = "楼层")]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        [Editable(true)]
        public string FLOOR { get; set; }

        /// <summary>
        ///系统编码
        /// </summary>
        [Display(Name = "系统编码")]
        [MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        [Editable(true)]
        public string SYSTEM_CODE { get; set; }

        /// <summary>
        ///类型
        /// </summary>
        [Display(Name = "类型")]
        [Column(TypeName = "smallint")]
        public int? EFFECTIVE_TYPE { get; set; }

        /// <summary>
        ///修改人
        /// </summary>
        [Display(Name = "修改人")]
        [Column(TypeName = "int")]
        public int? ModifyID { get; set; }

        /// <summary>
        ///修改日期
        /// </summary>
        [Display(Name = "修改日期")]
        [Column(TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        ///启用轮廓
        /// </summary>
        [Display(Name = "启用轮廓")]
        [Column(TypeName = "smallint")]
        [Editable(true)]
        public int? BORDER_ENABLE { get; set; }

        /// <summary>
        ///启用阴影
        /// </summary>
        [Display(Name = "启用阴影")]
        [Column(TypeName = "smallint")]
        [Editable(true)]
        public int? SHADOW_ENABLE { get; set; }

        /// <summary>
        ///相机位
        /// </summary>
        [Display(Name = "相机位")]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        [Editable(true)]
        public string CAMERA { get; set; }

        /// <summary>
        ///Guid
        /// </summary>
        [Display(Name = "Guid")]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Editable(true)]
        public string GUID { get; set; }

        /// <summary>
        ///描述
        /// </summary>
        [Display(Name = "描述")]
        [MaxLength(255)]
        [Column(TypeName = "varchar(255)")]
        [Editable(true)]
        public string DESCRIPTION { get; set; }


    }
}