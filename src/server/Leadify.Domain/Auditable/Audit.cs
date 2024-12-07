﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Leadify.Domain.Auditable;

public class Audit
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    public string? Operation { get; set; }
    public string? TableName { get; set; }
    public Ulid RecordId { get; set; }
    public IEnumerable<AuditEntry> Changes { get; set; } = [];
    public DateTime? ChangeDate { get; set; }
}
