using System.ComponentModel.DataAnnotations;

namespace BowlingFun.Data
{
    public class BowlingLeague
    {
        [Key]
        public int? bowlerID { get; set; }
        
        public string? bowlerFirstName { get; set; }
        
        public string? bowlerMiddleInit { get; set; }
        
        public string? bowlerLastName { get; set; }
        
        public int? teamID { get; set; }


        // Add navigation property
        public Team? Team { get; set; }  // Navigation to the Team entity


        public string? bowleraddress { get; set; }
        
        public string? bowlercity { get; set; }
        
        public string? bowlerstate { get; set; }
        
        public string? bowlerzip { get; set; }
        
        public string? bowlerphoneNumber { get; set; }
    }

}
