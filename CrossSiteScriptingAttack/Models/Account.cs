using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CrossSiteScriptingAttack.Models
{
	public class Account
	{
       
        [Required]       
        public decimal Amount { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression("^[a-zA-Z0-9]*$")]
        public string TransferTo { get; set; }
    }
}