using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace NameList.Model
{

    [Table("m_person")]
    public class Person
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public Person(int personId, string personName, int departmentId, string mailAddress, string phoneNumber, string detail, DateTime createdDateTime, DateTime updatedDateTime)
        {
            this.personId = personId;
            this.personName = personName;
            this.departmentId = departmentId;
            this.mailAddress = mailAddress;
            this.phoneNumber = phoneNumber;
            this.detail = detail;
            this.createdDateTime = createdDateTime;
            this.updatedDateTime = updatedDateTime;
        }

        public Person()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]  //NotNULL
        [DisplayName("社員ID")]
        public int personId { get; set; }

        [Required]
        [DisplayName("名前")]
        [StringLength(100)]
        public string personName { get; set; }

        [Required]
        [DisplayName("部署ID")]
        public int departmentId { get; set; }

        [DisplayName("メールアドレス")]
        [EmailAddress]
        public string mailAddress { get; set; }

        [DisplayName("電話番号")]
        [StringLength(100)]
        public string phoneNumber { get; set; }

        [DisplayName("詳細")]
        [StringLength(100)]
        public string detail { get; set; }

        [DisplayName("作成日時")]
        public DateTime createdDateTime { get; set; }

        [DisplayName("更新日時")]
        public DateTime updatedDateTime { get; set; }
    }
}
