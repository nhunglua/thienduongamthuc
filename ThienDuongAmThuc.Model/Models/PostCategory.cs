using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThienDuongAmThuc.Model.Abstract;

namespace ThienDuongAmThuc.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        public bool? HomeFlag { set; get; }

        //PostCategory chỉ đến post
        public virtual IEnumerable<Post> Posts { set; get; }
    }
}