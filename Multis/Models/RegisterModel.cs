using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multis.Models
/*
1. Логин*
2. Юридическое название компании*
3. Маркетинговое название*
4. Руководитель фирмы*
5. Номер телефона руководителя*
6. Email адрес*
7. Страна работы*
8. Город 
9. Адрес магазина
10. Номер счета компании
*/
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
                
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Не указано юридическое название компании")]
        public string JName { get; set; }
        
        [Required(ErrorMessage = "Не указано маркетинговое название компании")]
        public string MName { get; set; }

        [Required(ErrorMessage = "Не указан руководитель компании")]
        public string Superviser { get; set; }

        [Required(ErrorMessage = "Не указан номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string SuperPhoneNum { get; set; }
                
        [Required(ErrorMessage = "Не указан Email")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        
        public string Country { get; set; }
        [Required(ErrorMessage = "Не указан город")]
        public string City { get; set; }
        [Required(ErrorMessage = "Не указан адрес магазина")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Не номер счета")]
        public string Account { get; set; }



    }
}
