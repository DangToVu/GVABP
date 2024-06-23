using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.GVABP.GiangViens;

public class GiangVien : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public SubjectType Type { get; set; }

    public DateTime Birthday { get; set; }

    public float Salary { get; set; }
}
