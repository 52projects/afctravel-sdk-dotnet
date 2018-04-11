using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFCTravel.Api.Sets;
using System.Net;

namespace AFCTravel.Api {
    public class AFCTravelRestClient {
        private string _username;
        private string _secretKey;
        private string _accessCode;
        private TripSet _trips;
        private PNRSet _pnrs;
        private string _baseUrl = "https://www.managedtrip.com/ManagedTrip/api/partner/1.0/";

        public AFCTravelRestClient(string username, string secretkey, string accessCode) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            _username = username;
            _secretKey = secretkey;
            _accessCode = accessCode;
        }

        public AFCTravelRestClient(string username, string secretkey, string accessCode, string baseUrl) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            _username = username;
            _secretKey = secretkey;
            _accessCode = accessCode;
            _baseUrl = baseUrl;
        }



        public TripSet Trips {
            get {
                if (_trips == null) {
                    _trips = new TripSet(_username, _secretKey, _accessCode, _baseUrl);
                }
                return _trips;
            }
        }

        public PNRSet PNRs {
            get {
                if (_pnrs == null) {
                    _pnrs = new PNRSet(_username, _secretKey, _accessCode, _baseUrl);
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
