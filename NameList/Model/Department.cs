using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NameList.Model
{
    [Table("m_department")]
    public class Department
    {
        public Department(int departmentId, string phoneNumber, int upPersonId, DateTime createdDateTime, DateTime updatedDateTime)
        {
            this.departmentId = departmentId;
            this.phoneNumber = phoneNumber;
            this.upPersonId = upPersonId;
            this.createdDateTime = createdDateTime;
            this.updatedDateTime = updatedDateTime;
        }

        public Department()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]  //NotNULL
        [DisplayName("部署ID")]
        public int departmentId { get; set; }

        [Required]
        [DisplayName("部署名")]
        [StringLength(100)]
        public string phoneNumber { get; set; }

        [Required]
        [DisplayName("部署長")]
        public int upPersonId { get; set; }

        [DisplayName("作成日時")]
        public DateTime createdDateTime { get; set; }

        [DisplayName("更新日時")]
        public DateTime updatedDateTime { get; set; }
    }
}
