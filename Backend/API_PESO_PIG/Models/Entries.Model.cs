﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_PESO_PIG.Models
{
    public class Entries
    {
        [Key]
        public int id_Entries { get; set; }

        public int vlr_Unitary { get; set; }
        public int vlr_Total { get; set; }

        public DateTime Fec_Entries { get; set; }

        public DateTime Fec_Expiration { get; set; }

        public int Can_Food { get; set; }
        public int Vlr_Promedio { get; set; }

        public int id_Food { get; set; }


        [ForeignKey("id_Food")]
        public Food? food { get; set; }
    }
}