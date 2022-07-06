using System.ComponentModel.DataAnnotations;

namespace helloweb.Models{
    class User{
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(20)]
        [Required]
        public string username { get; set; }
        [MaxLength(100)]
        [EmailAddress]
        public string email { get; set; }
        [Required] 
        public string password { get; set; }
    }
}