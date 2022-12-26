using System;
using System.Collections.Generic;

namespace StudentTest.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentAdd { get; set; } = null!;

    public string StudentClass { get; set; } = null!;
}
