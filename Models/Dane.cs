using System.ComponentModel.DataAnnotations;

namespace lab3_forms.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię musi zawierać minimum 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi zawierać minimum 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać adres e-mail")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła nie są zgodne")]
        [DataType(DataType.Password)]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być między 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać miasto")]
        public Miasta Miasto { get; set; }

        public enum Miasta
        {
            Warszawa,
            Krakow,
            Gdansk,
            Wroclaw,
            Poznan
        }
    }
}