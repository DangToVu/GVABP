using System;
using Volo.Abp.Application.Dtos;

namespace Acme.GVABP.GiangViens;

public class GiangVienDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public SubjectType Type { get; set; }

    public DateTime Birthday { get; set; }

    public float Salary { get; set; }
}
