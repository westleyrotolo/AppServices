using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppServices.Models
{
    public class App : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long             ID                { get; set; }
        public string           Name              { get; set; }
        public ApplicationType  ApplicationType   { get; set; }
        public ApplicationUser  ApplicationUser   { get; set; }
        public string           ApplicationUserID { get; set; }
        public virtual ICollection<RemoteConfig> RemoteConfigs { get; set; }
    }
    public enum ApplicationType
    {
        Android, 
        iOS,
        Web,
        Desktop
    }
}
