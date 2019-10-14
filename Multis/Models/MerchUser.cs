using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multis.Models
{
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
    public class MerchUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string JName { get; set; }
        public string MName { get; set; }
        public string Suprviser { get; set; }
        public string SuperPhoneNum { get; set; }
        public string EMail { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ShopAddress { get; set; }
        public string Account { get; set; }
    }
}
