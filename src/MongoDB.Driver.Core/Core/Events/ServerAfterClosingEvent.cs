﻿/* Copyright 2013-2014 MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using MongoDB.Driver.Core.Servers;

namespace MongoDB.Driver.Core.Events
{
    public struct ServerAfterClosingEvent
    {
        private readonly ServerId _serverId;
        private readonly TimeSpan _elapsed;

        public ServerAfterClosingEvent(ServerId serverId, TimeSpan elapsed)
        {
            _serverId = serverId;
            _elapsed = elapsed;
        }

        public TimeSpan Elapsed
        {
            get { return _elapsed; }
        }

        public ServerId ServerId
        {
            get { return _serverId; }
        }
    }
}
