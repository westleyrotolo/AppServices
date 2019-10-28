using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppServices.Models
{
    public class RemoteConfig : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public App App { get; set; }
       public long AppID { get; set; }
        public string Key { get; set; }
        public string  Value { get; set; }
    }
}
