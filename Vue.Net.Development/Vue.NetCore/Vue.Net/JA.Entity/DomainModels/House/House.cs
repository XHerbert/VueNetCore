using Newtonsoft.Json;
/*
 *Author：xuhbd
 *Contact：xuhbd@foxmail.com
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
using JA.Entity.SystemModels;

namespace JA.Entity.DomainModels
{
    [Entity(TableCnName = "房屋管理",TableName = "House")]
    public class House:BaseEntity
    {
        /// <summary>
       ///序号
       /// </summary>
       [Key]
       [Display(Name ="序号")]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///房屋编码
       /// </summary>
       [Display(Name ="房屋编码")]
       [MaxLength(45)]
       [Column(TypeName="nvarchar(45)")]
       [Required(AllowEmptyStrings=false)]
       public string HouseCode { get; set; }

       /// <summary>
       ///房号
       /// </summary>
       [Display(Name ="房号")]
       [MaxLength(25)]
       [Column(TypeName="nvarchar(25)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string HouseNumber { get; set; }

       /// <summary>
       ///房屋面积(平米)
       /// </summary>
       [Display(Name ="房屋面积(平米)")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal Area { get; set; }

       /// <summary>
       ///所属单位
       /// </summary>
       [Display(Name ="所属单位")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int BelongUnit { get; set; }

       /// <summary>
       ///地址
       /// </summary>
       [Display(Name ="地址")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string HouseAddress { get; set; }

       /// <summary>
       ///房屋类别
       /// </summary>
       [Display(Name ="房屋类别")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? HouseType { get; set; }

       /// <summary>
       ///房屋状态
       /// </summary>
       [Display(Name ="房屋状态")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? HouseStatus { get; set; }

       /// <summary>
       ///房屋租金(元)
       /// </summary>
       [Display(Name ="房屋租金(元)")]
       [DisplayFormat(DataFormatString="10,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public decimal RentFee { get; set; }

       /// <summary>
       ///是否启用
       /// </summary>
       [Display(Name ="是否启用")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EnableFlag { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreatorID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       [Required(AllowEmptyStrings=false)]
       public int CreatorID { get; set; }

       /// <summary>
       ///创建人
       /// </summary>
       [Display(Name ="创建人")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Required(AllowEmptyStrings=false)]
       public string Creator { get; set; }

       /// <summary>
       ///创建时间
       /// </summary>
       [Display(Name ="创建时间")]
       [Column(TypeName="datetime")]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [JsonIgnore]
       [Column(TypeName="int")]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [JsonIgnore]
       [Column(TypeName="datetime")]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(30)]
       [JsonIgnore]
       [Column(TypeName="nvarchar(30)")]
       public string Modifier { get; set; }

       
    }
}
