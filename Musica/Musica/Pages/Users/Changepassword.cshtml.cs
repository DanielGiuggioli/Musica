using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musica
{
    public class ChangepasswordModel : PageModel
    {
        private readonly MusicaDbContext _context;
        public ChangepasswordModel(MusicaDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string OldPassword { get; set; }
        [BindProperty]
        public string NewPassword { get; set; }
        [BindProperty]
        public string newConfirmedPassword { get; set; }
        [BindProperty]
        public string ErrorText { get; set; }
        public User GetUser() => CookiesManager.GetUserByCookies(HttpContext.Request, _context);
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(OldPassword) ||
                string.IsNullOrEmpty(NewPassword) ||
                string.IsNullOrEmpty(newConfirmedPassword))
            {
                ErrorText = "Empty fields in the form";
                return Page();
            }
            string encOldPassword = PasswordManager.EncodePasswordToBase64(OldPassword);

            if (GetUser().Password != encOldPassword)
            {
                ErrorText = "Old password wrong";
                return Page();
            }
            string encNewPassword = PasswordManager.EncodePasswordToBase64(NewPassword);
            string encConfirmedPassword = PasswordManager.EncodePasswordToBase64(newConfirmedPassword);
            if (encNewPassword != encConfirmedPassword)
            {
                ErrorText = "Passwords doesn't match";
                return Page();
            }
            _context.Users.SingleOrDefault(x => x.Id == GetUser().Id).Password = encNewPassword;
            _context.SaveChanges();
            ErrorText = string.Empty;
            return RedirectToPage("/users/Index");
        }
    }
}
