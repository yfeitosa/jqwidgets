using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication6.Anotacoes
{
    public class Pessoa
    {
        public Int32 Codigo
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Informe o Campo Nome")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Digite entre 2 e 10 bytes")]
        public String Nome
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Informe o Campo EMail")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$", ErrorMessage = "Preencha Corretamente o Email")]
        public String Email
        {
            get;
            set;
        }

        [Range(1, 100, ErrorMessage = "Idade deve estar entre 1 e 100")]
        public Int32 Idade
        {
            get;
            set;
        }


        //private String _Nome;
        //[Required(ErrorMessage = "Informe o Campo Nome")]
        //[StringLength(10, MinimumLength = 2, ErrorMessage = "Digite entre 2 e 10 bytes")]
        //public String Nome
        //{
        //    get
        //    {
        //        return _Nome;
        //    }
        //    set
        //    {
        //        Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Nome" });
        //        _Nome = value;
        //    }
        //}

        //[Required(ErrorMessage = "Informe o Campo EMail")]
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$", ErrorMessage = "Preencha Corretamente o Email")]
        //public String Email
        //{
        //    get;
        //    set;
        //}

        //[Range(1, 100, ErrorMessage = "Idade deve estar entre 1 e 100")]
        //public Int32 Idade
        //{
        //    get;
        //    set;
        //}
    }
}
