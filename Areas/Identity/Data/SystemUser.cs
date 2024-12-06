using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SystemIdentity.Models;

namespace SystemIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SystemUser class
public class SystemUser : IdentityUser
{
    public string Nickname => Email.Substring(0, Email.IndexOf("@")); 
    public virtual ICollection<Car>? MyCar {  get; set; }
}

