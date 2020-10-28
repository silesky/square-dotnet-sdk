using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class SearchTeamMembersFilter 
    {
        public SearchTeamMembersFilter(IList<string> locationIds = null,
            string status = null)
        {
            LocationIds = locationIds;
            Status = status;
        }

        /// <summary>
        /// When present, filter by team members assigned to the specified locations.
        /// When empty, include team members assigned to any location.
        /// </summary>
        [JsonProperty("location_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> LocationIds { get; }

        /// <summary>
        /// Enumerates the possible statuses the team member can have within a business.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .LocationIds(LocationIds)
                .Status(Status);
            return builder;
        }

        public class Builder
        {
            private IList<string> locationIds;
            private string status;



            public Builder LocationIds(IList<string> locationIds)
            {
                this.locationIds = locationIds;
                return this;
            }

            public Builder Status(string status)
            {
                this.status = status;
                return this;
            }

            public SearchTeamMembersFilter Build()
            {
                return new SearchTeamMembersFilter(locationIds,
                    status);
            }
        }
    }
}