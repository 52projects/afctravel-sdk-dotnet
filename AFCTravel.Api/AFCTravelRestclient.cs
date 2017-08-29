using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFCTravel.Api.Sets;

namespace AFCTravel.Api {
    public class AFCTravelRestClient {
        private string _username;
        private string _secretKey;
        private string _accessCode;
        private TripSet _trips;
        private PNRSet _pnrs;

        public AFCTravelRestClient(string username, string secretkey, string accessCode) {
            _username = username;
            _secretKey = secretkey;
            _accessCode = accessCode;
        }


        public TripSet Trips {
            get {
                if (_trips == null) {
                    _trips = new TripSet(_username, _secretKey, _accessCode);
                }
                return _trips;
            }
        }

        public PNRSet PNRs {
            get {
                if (_pnrs == null) {
                    _pnrs = new PNRSet(_username, _secretKey, _accessCode);
                }
                return _pnrs;
            }
        }
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
