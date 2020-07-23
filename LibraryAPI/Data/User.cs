using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
    }
}
