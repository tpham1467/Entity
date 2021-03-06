    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    namespace Entity
    {
        [Table("CaLam")]
        public class CaLam
        {
            public CaLam()
            {
                this.ChiTietCaLams = new HashSet<ChiTietCaLam>();
            }
            [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Required]
            public int ID_CaLam { get; set; }
            public string LichCaLam { get; set; }
            public virtual ICollection<ChiTietCaLam> ChiTietCaLams { get; set; }
        }
    }