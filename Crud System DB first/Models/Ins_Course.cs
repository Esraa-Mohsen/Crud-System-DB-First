﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace taske55.Models;

[PrimaryKey("Ins_Id", "Crs_Id")]
[Table("Ins_Course")]
public partial class Ins_Course
{
    [Key]
    public int Ins_Id { get; set; }

    [Key]
    public int Crs_Id { get; set; }

    [StringLength(50)]
    public string Evaluation { get; set; }

    [ForeignKey("Crs_Id")]
    [InverseProperty("Ins_Courses")]
    public virtual Course Crs { get; set; }

    [ForeignKey("Ins_Id")]
    [InverseProperty("Ins_Courses")]
    public virtual Instructor Ins { get; set; }
}