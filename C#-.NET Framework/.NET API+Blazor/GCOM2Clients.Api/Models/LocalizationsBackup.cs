using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LocalizationsBackup
{
    public int Pk { get; set; }

    public string ResourceId { get; set; } = null!;

    public string? Value { get; set; }

    public string? LocaleId { get; set; }

    public string? ResourceSet { get; set; }

    public string? Type { get; set; }

    public byte[]? BinFile { get; set; }

    public string? TextFile { get; set; }

    public string? Filename { get; set; }

    public string? Comment { get; set; }

    public int ValueType { get; set; }

    public DateTime? Updated { get; set; }
}
