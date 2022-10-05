using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Dtos
{
    public class ResourceFileDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ResourceId { get; set; }

        public string Url { get; set; }

        public string UniqueFileName { get; set; }

        public FileType FileType { get; set; }
        
    }
}
