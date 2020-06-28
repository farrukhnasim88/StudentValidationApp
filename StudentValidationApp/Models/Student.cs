using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentValidationApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Please enter your First Name."), MaxLength(20)]
        [Column("First Name")]  // will show table name in DB
        [DisplayName("First Name")] // displa name in View

        public string FirstName { get; set; }



        [Required(ErrorMessage ="Please Enter your Last Name.")]
        [Column ("Last Name")]
        [Display(Name ="Last Name"), MaxLength(20)]
        public string LastName { get; set; }

        [Required (ErrorMessage ="Please enter Marks."), MaxLength(3), MinLength(1)]
        public int Marks { get; set; }



        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Please Enter Email Address.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

        public string Email { get; set; }


        [Required (ErrorMessage ="Please Enter Department Name.")]
        [StringLength(30, MinimumLength =2)]
        public string Department { get; set; }

        public string FullName
        {

            get { return FirstName + " " + LastName; }

        }


        [Required (ErrorMessage ="Please Enter Mobile Number."), MaxLength(10), MinLength(10)]
      [DisplayName("Contact No")]
        [DataType(DataType.PhoneNumber)]
        public int MobileNo { get; set; }



    }
}
