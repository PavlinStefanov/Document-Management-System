using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentSystem.WebApi.Infrastructure.Model
{
    public class ContractType
    {
        public ContractType()
        {
            Contracts = new HashSet<Contract>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
