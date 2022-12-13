
using System.ComponentModel.DataAnnotations;

namespace TP4.Models;

public class Student
{

    [Key]
    public Int32 Id { get; init; }

    public string? first_name { get; init; }
    public string? last_name { get; init; }
    public string? phone_number { get; init; }
    public string? university { get; init; }

    [DataType(DataType.DateTime)]
    public DateTime timestamp { get; init; }

    public string? course { get; init; }
}