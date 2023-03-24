using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssurityConsultingTestAssessment.Models
{ 

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Fees
    {
        public float Bundle { get; set; }
        public double EndDate { get; set; }
        public float Feature { get; set; }
        public float Gallery { get; set; }
        public float Listing { get; set; }
        public double Reserve { get; set; }
        public double Subtitle { get; set; }
        public double TenDays { get; set; }
        public List<ListingFeeTier> ListingFeeTiers { get; set; }
        public double SecondCategory { get; set; }
    }

    public class ListingFeeTier
    {
        public float MinimumTierPrice { get; set; }
        public float FixedFee { get; set; }
    }

    public class Promotion
    {
        public float Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float MinimumPhotoCount { get; set; }
        public float? OriginalPrice { get; set; }
        public bool? Recommended { get; set; }
    }

    public class CategoriesDeatils
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool CanListAuctions { get; set; }
        public bool CanListClassifieds { get; set; }
        public bool CanRelist { get; set; }
        public string LegalNotice { get; set; }
        public int DefaultDuration { get; set; }
        public List<int> AllowedDurations { get; set; }
        public Fees Fees { get; set; }
        public int FreePhotoCount { get; set; }
        public int MaximumPhotoCount { get; set; }
        public bool IsFreeToRelist { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<object> EmbeddedContentOptions { get; set; }
        public int MaximumTitleLength { get; set; }
        public int AreaOfBusiness { get; set; }
        public int DefaultRelistDuration { get; set; }
        public bool CanUseCounterOffers { get; set; }
    }


}
