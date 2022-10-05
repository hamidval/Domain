using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Enums;

namespace Domain.Dtos
{
    public class ResourceCreatorDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public int Limit { get; set; }
    }
}
