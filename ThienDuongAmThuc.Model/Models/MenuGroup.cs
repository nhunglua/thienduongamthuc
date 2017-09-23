using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThienDuongAmThuc.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        //Khi menugroup.menus nó sẽ lấy ra được tất cả các menu thuộc group này.
        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}