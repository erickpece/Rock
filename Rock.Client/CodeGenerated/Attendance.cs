//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Simple Client Model for Attendance
    /// </summary>
    public partial class Attendance
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public AttendanceCode AttendanceCode { get; set; }

        /// <summary />
        public int? AttendanceCodeId { get; set; }

        /// <summary />
        public int? CampusId { get; set; }

        /// <summary />
        public Device Device { get; set; }

        /// <summary />
        public int? DeviceId { get; set; }

        /// <summary />
        public bool? DidAttend { get; set; }

        /// <summary />
        public bool? DidNotOccur { get; set; }

        /// <summary />
        public DateTime? EndDateTime { get; set; }

        /// <summary />
        public int? GroupId { get; set; }

        /// <summary />
        public int? LocationId { get; set; }

        /// <summary />
        public string Note { get; set; }

        /// <summary />
        public int? PersonAliasId { get; set; }

        /// <summary />
        public bool? Processed { get; set; }

        /// <summary />
        public DefinedValue Qualifier { get; set; }

        /// <summary />
        public int? QualifierValueId { get; set; }

        /// <summary />
        public int /* RSVP*/ RSVP { get; set; }

        /// <summary />
        public int? ScheduleId { get; set; }

        /// <summary />
        public DefinedValue SearchTypeValue { get; set; }

        /// <summary />
        public int? SearchTypeValueId { get; set; }

        /// <summary />
        public DateTime StartDateTime { get; set; }

        /// <summary />
        public DateTime? CreatedDateTime { get; set; }

        /// <summary />
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary />
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary />
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public string ForeignId { get; set; }

        /// <summary />
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }


        /// <summary />
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }

    }
}
