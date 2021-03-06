﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCRUD.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        //Name
        [Required(ErrorMessage = "Nhập đầy đủ tên")]
        [StringLength(4, ErrorMessage = "Tên nên có ít nhất 4 ký tự")]
        public string Name { get; set; }

        //address
        [Required(ErrorMessage = "Nhập địa chỉ")]
        [StringLength(10, ErrorMessage = "Địa chỉ nên có ít nhất 10 ký tự")]
        public string Address { get; set; }

        //phonenumber
        [Required(ErrorMessage = "Nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Mobileno { get; set; }

        //DOB
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Nhập ngày tháng năm sinh")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [MVCCRUD.Models.CustomValidationAttributeDemo.ValidBirthDate(ErrorMessage = "Ngày sinh không thể là ngày muộn hơn ngày hiện tại")]
        public DateTime Birthdate { get; set; }

        //Email
        [Required(ErrorMessage = "Nhập EmailId")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Xin hãy nhập địa chỉ email hợp lệ")]
        public string EmailID { get; set; }

        public List<Customer> ShowallCustomer { get; set; }
    }
}
