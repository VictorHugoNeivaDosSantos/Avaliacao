using AvaliaçãoTecnobyte.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliaçãoTecnobyte.Models
{
    public class People
    {
        public long PeopleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public TypePeople TypePeople { get; set; }
        [Required]
        public bool Situation { get; set; }   
        public string CpfCnpj { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
