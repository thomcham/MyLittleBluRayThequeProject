using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLittleBluRayThequeProject.Entity
{
    [Table("BluRay")]
    public class BluRay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Titre { get; set; }

        public Personne Scenariste { get; set; }

        public Personne Realisateur { get; set; }

        public List<Personne> Acteurs { get; set; }


        public TimeSpan Duree { get; set; }


        public DateTime DateSortie { get; set; }


        public List<string> Langues { get; set; }

        public List<string> SsTitres { get; set; }

        public string Version { get; set; }

    }
}
