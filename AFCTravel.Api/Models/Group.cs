using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFCTravel.Api.Models {
    public class Group {
        public DateTime? CancelledDate { get; set; }
        public DateTime? DepositDueDate { get; set; }
        public DateTime? DepositNonRefundable2Date { get; set; }
        public DateTime? DepositNonRefundableDate { get; set; }

        public DateTime? FinalNamesDueDate { get; set; }
        public string FinalNamesDueNotes { get; set; }
        public string FinalNamesGoogleSheetsId { get; set; }
        public string FinalNamesGoogleSheetsWebUrl { get; set; }
        public DateTime? FinalNamesReceivedDate { get; set; }
        public DateTime? FinalPaymentDueDate { get; set; }
        public string FinalPaymentDueNotes { get; set; }

        public DateTime? LastDayToCancelDate { get; set; }
        public DateTime? LastDayToTicketDate { get; set; }
        public decimal? PerSeatDepositAmount { get; set; }
        public decimal? PercentDepositNonRefundable { get; set; }
        public decimal? PercentDepositNonRefundable2 { get; set; }
        public string PercentDepositNonRefundableNotes { get; set; }
        public string PercentDepositNonRefundableNotes2 { get; set; }
        public decimal? PercentFinalNamesDue { get; set; }
        public DateTime? PercentFinalNamesDueDate { get; set; }
        public string PercentFinalNamesDueNotes { get; set; }
        public DateTime? SignedContractReceivedDate { get; set; }
        public DateTime? TickedDate { get; set; }
        public decimal? TotalDepositAmount { get; set; }



    }
}
