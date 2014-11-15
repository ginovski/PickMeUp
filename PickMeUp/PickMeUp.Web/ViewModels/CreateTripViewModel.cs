namespace PickMeUp.Web.ViewModels
{
    using PickMeUp.Models;
    using PickMeUp.Web.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class CreateTripViewModel : IMapFrom<Trip>
    {
        [Display(Name="Available Seats")]
        [Required]
        public int AvailableSeats { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Additional Information")]
        [DataType(DataType.MultilineText)]
        public string AdditionalInformation { get; set; }

        [Display(Name = "From")]
        [Required]
        public int FromId { get; set; }

        [Display(Name = "To")]
        [Required]
        public int ToId { get; set; }
    }
}