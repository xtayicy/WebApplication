using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Book
    {
        /*[DatabaseGenerated(DatabaseGeneratedOption.None)]*/
        [Key]
        public int Id { get; set; }

        [Column("person_id")]
        public int? PersonId { get; set; }

        public string Name { get; set; }

        public Person? Person { get; set; }

        public Book() { }

        public Book(string name) {
            this.Name = name;
        }
    }
}
