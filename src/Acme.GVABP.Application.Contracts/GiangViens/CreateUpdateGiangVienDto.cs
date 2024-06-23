using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.GVABP.GiangViens;

public class CreateUpdateGiangVienDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public SubjectType Type { get; set; } = SubjectType.Undefined;

    [Required]
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; } = DateTime.Now;

    [Required]
    public float Salary { get; set; }
}
