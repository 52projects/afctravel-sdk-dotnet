using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFCTravel.Api.Models;

namespace AFCTravel.Api.Sets {
    public class TripSet : BaseApiSet<Trip> {
        private const string LIST_URL = "";
        private const string SEARCH_URL = "";
        private const string SHOW_URL = "/trip/{0}";
        private const string CREATE_URL = "";

        public TripSet(string username, string secretKey, string accessCode) : base(username, secretKey, accessCode, ContentType.JSON) {

        }
        protected override string ListUrl { get { return LIST_URL; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl {
            get {
                return CREATE_URL;
            }
        }

        protected override string GetUrl {
            get {
                return SHOW_URL;
            }
        }

        protected override string EditUrl {
            get {
                return SHOW_URL;
            }
        }

        protected override string GetChildListUrl {
            get {
                return LIST_URL;
            }
        }
    }
}
