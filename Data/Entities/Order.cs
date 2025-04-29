using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gestor_backend.Data.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [ForeignKey("cliente")]
        public int ClientId { get; set; }
        
        [ForeignKey(nameof(State))]
        public int StateId { get; set; }
        public State State { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        [ForeignKey(nameof(PaymentMethod))]
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        
        public DateTime DeliveryDate { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
