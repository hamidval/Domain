using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domaim.Dtos
{
    public class ResourceHtmlDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int PageNumber { get; set; }
        public string HtmlString { get; set; }
    }
}
