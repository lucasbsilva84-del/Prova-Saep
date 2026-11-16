using System.ComponentModel.DataAnnotations;
namespace ClinicaVeterinaria.ViewModels;
public class RegistroViewModel
{
    [Required, StringLength(100, MinimumLength = 2)]
    [Display(Name = "Nome completo")]
    public string Nome { get; set; } = string.Empty;
    [Required, EmailAddress, StringLength(150)]
    [Display(Name = "E-mail")]
    public string Email { get; set; } = string.Empty;
    [Required, MinLength(8, ErrorMessage = "A senha deve ter pelo menos 8 caracteres."), DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Senha { get; set; } = string.Empty;
    [Required, Compare(nameof(Senha), ErrorMessage = "As senhas não coincidem."), DataType(DataType.Password)]
    [Display(Name = "Confirmar senha")]
    public string ConfirmarSenha { get; set; } = string.Empty;
}
