using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Tool.Models
{
    public class Student
    {
        [Column]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }
    }


    public class GapEntity
    {
        public int ID { get; set; }
        public virtual ICollection<GapAttachmentEntity> Attachments { get; set; }
    }

    public class GapAttachmentEntity
    {
        public int ID { get; set; }
        public int GAP_ID { get; set; }
        public virtual GapEntity GapEntity { get; set; }
    }
}
