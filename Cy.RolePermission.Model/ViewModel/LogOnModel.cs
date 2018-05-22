using System.ComponentModel.DataAnnotations;

namespace Cy.RolePermission.Model.ViewModel
{
    public class LogOnModel
    {
        [Required(ErrorMessage ="请填写用户名")]
        public string UserName { get; set; }
        [StringLength(maximumLength:10,ErrorMessage ="密码请不要超出10个字符")]
        [Required(ErrorMessage ="请填写密码")]
        public string PassWord { get; set; }
        [Required(ErrorMessage ="请填写验证码")]
        public string ValidateCode { get; set; }
        public bool RememberMe { get; set; }
    }
}
