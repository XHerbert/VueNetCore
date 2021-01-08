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
    [Entity(TableCnName = "行为列表",TableName = "Gfm_bim_model_effective_detail")]
[Table("Gfm_bim_model_effective_detail")]
    public class ModelEffectiveDetail:BaseEntity
    {
        /// <summary>
       ///子场景
       /// </summary>
       [Display(Name ="子场景")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int MAIN_ID { get; set; }

       /// <summary>
       ///目标模型
       /// </summary>
       [Display(Name ="目标模型")]
       [MaxLength(20)]
       [Column(TypeName="nvarchar(20)")]
       [Editable(true)]
       public string TARGET_MODEL { get; set; }

       /// <summary>
       ///动作类
       /// </summary>
       [Display(Name ="动作类")]
       [Column(TypeName="short")]
       [Editable(true)]
       public short? ACTION { get; set; }

       /// <summary>
       ///BIM方法
       /// </summary>
       [Display(Name ="BIM方法")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string EFFECT_KEY { get; set; }

       /// <summary>
       ///动作值
       /// </summary>
       [Display(Name ="动作值")]
       [MaxLength(255)]
       [Column(TypeName="nvarchar(255)")]
       [Editable(true)]
       public string ACTION_VALUE { get; set; }

       /// <summary>
       ///效果描述
       /// </summary>
       [Display(Name ="效果描述")]
       [MaxLength(1024)]
       [Column(TypeName="nvarchar(1024)")]
       [Editable(true)]
       public string DESCRIPTION { get; set; }

       /// <summary>
       ///行为取值
       /// </summary>
       [Display(Name ="行为取值")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string EFFECT_VALUE { get; set; }

       /// <summary>
       ///效果排序
       /// </summary>
       [Display(Name ="效果排序")]
       [Column(TypeName="short")]
       [Editable(true)]
       public short? ORDER { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? CREATE_STAFF_ID { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? CREATE_TIME { get; set; }

       /// <summary>
       ///有效标识
       /// </summary>
       [Display(Name ="有效标识")]
       [Column(TypeName="short")]
       public short? ENABLE_FLAG { get; set; }

       /// <summary>
       ///ID
       /// </summary>
       [Key]
       [Display(Name ="ID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int ID { get; set; }

       /// <summary>
       ///修改人
       /// </summary>
       [Display(Name ="修改人")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? MODIFY_STAFF_ID { get; set; }

       /// <summary>
       ///修改时间
       /// </summary>
       [Display(Name ="修改时间")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? MODIFY_TIME { get; set; }

       
    }
}
