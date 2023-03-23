using System.ComponentModel.DataAnnotations.Schema;

namespace guardarpdf.Models {

    [Table("pdf_guardado")]
    public class Ejemplo{
        public int id { get; set; }
        public string archivo { get; set; }
        
    }
}