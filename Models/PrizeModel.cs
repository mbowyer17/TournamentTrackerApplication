using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unqiue identifier for prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numerical indentifer for the placxe ( 2 for second, etc.)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The friendly name for the place (second place, first runner up, etc.)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if it is not used 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number represents the percentage of the overall take or 
        /// zero if its not used. The percentage is a fraction of 1 (so 0.5 for
        /// 50%)
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            // puts placeName parametre into PlaceName property
            PlaceName = placeName;

           
            int placeNumberValue = 0;
            // string we are storing it in
            int.TryParse(placeNumber, out placeNumberValue);
            // if you give me a invalid number, the string number will be set to placeNumberValue
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
