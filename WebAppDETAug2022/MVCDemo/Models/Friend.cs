using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models
{
    public class Friend
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string FriendName { get; set; }
        public string Place  { get; set; }
       
    }
}
