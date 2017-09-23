using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThienDuongAmThuc.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }


        // khi order.ordertail thì sẽ lấy được toàn bộ detail của thằng order này.
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}