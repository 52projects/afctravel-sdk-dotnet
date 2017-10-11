using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFCTravel.Api.Models;

namespace AFCTravel.Api.Sets {
    public class PNRSet : BaseApiSet<PNR> {
        private const string LIST_URL = "";
        private const string SEARCH_URL = "";
        private const string SHOW_URL = "/trip/{0}/pnr/{1}";
        private const string CREATE_URL = "";

        public PNRSet(string username, string secretKey, string accessCode, string baseUrl) : base(username, secretKey, accessCode, ContentType.JSON, baseUrl) {

        }

        private string _listUrl = string.Empty;
        protected override string ListUrl { get { return _listUrl; } }
        protected override string SearchUrl { get { return SEARCH_URL; } }

        protected override string CreateUrl {
            get {
                return CREATE_URL;
            }
        }

        private string _getUrl = string.Empty;
        protected override string GetUrl {
            get {
                return _getUrl;
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

        public List<PNR> List(int tripID, int pnrID, string accessCode) {
            _listUrl = string.Format(SHOW_URL, tripID, pnrID);
            AddParameter("accessCode", accessCode);
            return List();
        }
    }
}