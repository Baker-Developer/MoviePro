using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoviePro.Enums
{
    public enum MovieCategory
    {
        [Display(Name = "Now Playing")]
        now_playing,
        [Display(Name = "Popular")]
        popular,
        [Display(Name = "Top Rated")]
        top_rated,
        [Display(Name = "Upcoming")]
        upcoming
    }
}
