using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels;
    public class UpdateUserViewModel
    {
        [Required(ErrorMessage = "O Id não pode ser nulo")]
        [Range(1, long.MaxValue, ErrorMessage = "O id não pode ser menor que 1")]
        public int Id { get; set; }

        [Required(ErrorMessage = "A entidade não pode ser vazia")]
        [MinLength(10, ErrorMessage = "O email deve ter no mínimo 10 caracteres")]
        [MaxLength(180, ErrorMessage = "O email deve ter no máximo 180 caracteres")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = ("O email informado não é valido"))]
        public string? Email { get; set; } 

        [Required(ErrorMessage = "A entidade não pode ser vazia")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        [MaxLength(180, ErrorMessage = "A senha deve ter no máximo 180 caracteres")] 
        public string? Password { get; set; }   
    }