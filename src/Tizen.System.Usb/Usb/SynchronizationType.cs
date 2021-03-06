﻿/*
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

namespace Tizen.System.Usb
{
    /// <summary>
    /// Enumeration of isochronous endpoint's synchronization type.
    /// </summary>
    /// <since_tizen> 5 </since_tizen>
    public enum SynchronizationType
    {
        /// <summary>
        /// Asynchronous
        /// </summary>
        Asynchronous = Interop.SynchronizationType.Async,
        /// <summary>
        /// Adaptive
        /// </summary>
        Adaptive = Interop.SynchronizationType.Adaptive,
        /// <summary>
        /// Synchronous
        /// </summary>
        Synchronous = Interop.SynchronizationType.Sync,
    }
}