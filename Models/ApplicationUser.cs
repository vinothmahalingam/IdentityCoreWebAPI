using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace IdentityCoreWebAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Column(TypeName="nvarchar(150)")]
        public string FullName { get; set; }
    }
}