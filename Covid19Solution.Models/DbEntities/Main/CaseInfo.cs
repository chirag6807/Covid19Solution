using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using Covid19Solution.Models.Enums.Main;
using Covid19Solution.BoundedContext.SqlContext;
namespace Covid19Solution.Models.Main
{
    [Table("CaseInfos",Schema="dbo")]
    public partial class CaseInfo
    {
		#region Id Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion Id Annotations

        public int Id { get; set; }

		#region Name Annotations

        [Required]
        [MaxLength(50)]
		#endregion Name Annotations

        public string Name { get; set; }

		#region Age Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion Age Annotations

        public int Age { get; set; }

		#region Gender Annotations

        [Required]
        [MaxLength(50)]
		#endregion Gender Annotations

        public string Gender { get; set; }

		#region Address Annotations

        [Required]
		#endregion Address Annotations

        public string Address { get; set; }

		#region City Annotations

        [Required]
        [MaxLength(50)]
		#endregion City Annotations

        public string City { get; set; }

		#region Country Annotations

        [Required]
        [MaxLength(50)]
		#endregion Country Annotations

        public string Country { get; set; }

		#region Status Annotations

        [Required]
        [MaxLength(50)]
		#endregion Status Annotations

        public string Status { get; set; }


        public CaseInfo()
        {
        }
	}
}