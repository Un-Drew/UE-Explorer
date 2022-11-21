﻿using System;
using UELib;
using UELib.Annotations;

namespace UEExplorer.Framework
{
    [Serializable]
    public class PackageReference : IComparable<PackageReference>, IComparable<string>
    {
        [NotNull] public readonly string FilePath;
        public readonly DateTime RegisterDate;

        public PackageReference([NotNull] string filePath, [CanBeNull] UnrealPackage linker)
        {
            FilePath = filePath;
            RegisterDate = DateTime.Now;

            Linker = linker;
        }

        [field: NonSerialized] [CanBeNull] public UnrealPackage Linker { get; internal set; }

        public int CompareTo(PackageReference other) => other.FilePath.Equals(FilePath)
            ? 0
            : RegisterDate.CompareTo(other.RegisterDate);

        public int CompareTo(string other) => string.Compare(FilePath, other, StringComparison.Ordinal);

        public bool IsActive() => Linker != null;

        public override int GetHashCode() => FilePath.GetHashCode();
    }
}
