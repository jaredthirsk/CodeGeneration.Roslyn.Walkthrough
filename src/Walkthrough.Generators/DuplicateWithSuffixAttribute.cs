using CodeGeneration.Roslyn;
using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
[CodeGenerationAttribute(typeof(DuplicateWithSuffixGenerator))]
[Conditional("CodeGeneration")]
public class DuplicateWithSuffixAttribute : Attribute
{
    public DuplicateWithSuffixAttribute(string suffix)
    {
        if (string.IsNullOrEmpty(suffix)) throw new ArgumentException("Must not be null or empty", nameof(suffix));

        this.Suffix = suffix;
    }

    public string Suffix { get; }
}