/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.CallManager
{
    /// <summary>
    /// A class which defines the properties of call.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public class CallData
    {
        internal uint CallId;
        internal CallDirection CallDirection;
        internal string Number;
        internal string Name;
        internal CallType CallType;
        internal CallState CallState;
        internal int Count;
        internal bool IsEcc;
        internal bool IsVoiceMail;
        internal CallDomain CallDomain;
        internal int PersonIndex;
        internal long CallStartTime;
        internal CallNameMode CallNameMode;
        internal int SessionIdIms;
        internal bool IsHdEnableIms;
        internal bool IsWiFiCall;
        internal bool IsUpgradeDowngrade;
        internal bool IsRemoteHold;
        internal bool IsAddedToConf;
        internal bool IsForwardedCall;

        internal CallData()
        {
        }

        /// <summary>
        /// Gets call id.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public uint Id
        {
            get
            {
                return CallId;
            }
        }

        /// <summary>
        /// Gets call direction(MO or MT).
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public CallDirection Direction
        {
            get
            {
                return CallDirection;
            }
        }

        /// <summary>
        /// Get the call number.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public string CallNumber
        {
            get
            {
                return Number;
            }
        }

        /// <summary>
        /// Get the contact name of calling number.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public string CallingName
        {
            get
            {
                return Name;
            }
        }

        /// <summary>
        /// Get the call type(Voice call or Video call).
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public CallType Type
        {
            get
            {
                return CallType;
            }
        }

        /// <summary>
        /// Get the call state(Incoming, Active, etc).
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public CallState State
        {
            get
            {
                return CallState;
            }
        }

        /// <summary>
        /// Get the member count.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public int MemberCount
        {
            get
            {
                return Count;
            }
        }

        /// <summary>
        /// Checks if the call is emergency call.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsEmergency
        {
            get
            {
                return IsEcc;
            }
        }

        /// <summary>
        /// Checks if the number is voice mail number.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsVoiceMailNumber
        {
            get
            {
                return IsVoiceMail;
            }
        }

        /// <summary>
        /// Get the call domain(PS call, CS call, etc).
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public CallDomain Domain
        {
            get
            {
                return CallDomain;
            }
        }

        /// <summary>
        /// Get the person ID.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public int PersonId
        {
            get
            {
                return PersonIndex;
            }
        }

        /// <summary>
        /// Get the start time of the call.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public long StartTime
        {
            get
            {
                return CallStartTime;
            }
        }

        /// <summary>
        /// Get the contact name mode.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public CallNameMode Mode
        {
            get
            {
                return CallNameMode;
            }
        }

        /// <summary>
        /// Get the session ID of the call.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public int SessionId
        {
            get
            {
                return SessionIdIms;
            }
        }

        /// <summary>
        /// Checks if HD is enabled for calling.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsHdEnable
        {
            get
            {
                return IsHdEnableIms;
            }
        }

        /// <summary>
        /// Checks if the call is a WiFi call.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsWiFiCalling
        {
            get
            {
                return IsWiFiCall;
            }
        }

        /// <summary>
        /// Checks if upgrade/downgrade is enabled.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsUpgradeDowngradeEnable
        {
            get
            {
                return IsUpgradeDowngrade;
            }
        }

        /// <summary>
        /// Checks if the remote call is on hold.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsRemoteOnHold
        {
            get
            {
                return IsRemoteHold;
            }
        }

        /// <summary>
        /// Checks if the call is added to conference.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsAddedToConference
        {
            get
            {
                return IsAddedToConf;
            }
        }

        /// <summary>
        /// Checks if the incoming call is a forwarded call.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsMtForwarded
        {
            get
            {
                return IsForwardedCall;
            }
        }
    }
}
