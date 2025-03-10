﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTricariOtomasyon.Models.Classes
{
    public class Current
    {
        [Key]
        [Display(Name = "Cari Id")]
        public int CurrentId { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Cari Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter yazabilirsiniz")]
        public string CurrentName { get; set; }

        [Display(Name = "Cari Soyadı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        public string CurrentSurname { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Şehir")]
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CurrentCity { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Mail")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CurrentEmail { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz!")]
        [Display(Name = "Şifre")]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Password { get; set; }

        [Display(Name = "Durum")]
        public bool Status { get; set; }

        public ICollection<SalesMotion> SalesMotions { get; set; }
    }
}