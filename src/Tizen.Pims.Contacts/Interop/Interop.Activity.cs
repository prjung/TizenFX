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

using System.Runtime.InteropServices;

/// <summary>
/// Partial Interop Class
/// </summary>
internal static partial class Interop
{
    internal static class Activity
    {
        [DllImport(Libraries.Contacts, EntryPoint = "contacts_activity_delete_by_contact_id")]
        internal static extern int DeleteByContactId(int contactId);

        [DllImport(Libraries.Contacts, EntryPoint = "contacts_activity_delete_by_account_id")]
        internal static extern int DeleteByAccountId(int accountId);
    }
}
