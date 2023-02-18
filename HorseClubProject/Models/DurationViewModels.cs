using System.ComponentModel;
using HorseClubLibrary.Model.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HorseClubProject.Models;

public class DurationViewModels
{
    [DisplayName("Duration")] public int DurationId { get; set; }

    public List<DurationTours> ListofDuration { get; set; }
}