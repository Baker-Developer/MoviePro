using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MoviePro.Enums
{
    public enum MovieRating
    {
        [Display(Name = "G")]
        G,
        [Display(Name = "PG")]
        PG,
        [Display(Name = "PG-13")]
        PG13,
        [Display(Name = "R")]
        R,
        [Display(Name = "NC-17")]
        NC17,
        [Display(Name = "NR")]
        NR
    }
}
