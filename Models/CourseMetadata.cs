using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class CourseMetaData
{
    [StringLength(50)]
    [Display(Name= "Course Name")]
    public string Name { get; set; } = null!;

    [Required]
    [Display(Name= "Course Code")]
    public string? Code { get; set; }

    [Required]
    [Display(Name= "Course Credit")]
    public int? Credits { get; set; }
}

[ModelMetadataType(typeof(CourseMetaData))]
public partial class Course{}