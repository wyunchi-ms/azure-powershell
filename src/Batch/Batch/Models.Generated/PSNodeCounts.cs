﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSNodeCounts
    {
        
        internal Microsoft.Azure.Batch.NodeCounts omObject;
        
        internal PSNodeCounts(Microsoft.Azure.Batch.NodeCounts omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public int Creating
        {
            get
            {
                return this.omObject.Creating;
            }
        }
        
        public int Idle
        {
            get
            {
                return this.omObject.Idle;
            }
        }
        
        public int LeavingPool
        {
            get
            {
                return this.omObject.LeavingPool;
            }
        }
        
        public int Offline
        {
            get
            {
                return this.omObject.Offline;
            }
        }
        
        public int Preempted
        {
            get
            {
                return this.omObject.Preempted;
            }
        }
        
        public int Rebooting
        {
            get
            {
                return this.omObject.Rebooting;
            }
        }
        
        public int Reimaging
        {
            get
            {
                return this.omObject.Reimaging;
            }
        }
        
        public int Running
        {
            get
            {
                return this.omObject.Running;
            }
        }
        
        public int Starting
        {
            get
            {
                return this.omObject.Starting;
            }
        }
        
        public int StartTaskFailed
        {
            get
            {
                return this.omObject.StartTaskFailed;
            }
        }
        
        public int Total
        {
            get
            {
                return this.omObject.Total;
            }
        }
        
        public int Unknown
        {
            get
            {
                return this.omObject.Unknown;
            }
        }
        
        public int Unusable
        {
            get
            {
                return this.omObject.Unusable;
            }
        }
        
        public int WaitingForStartTask
        {
            get
            {
                return this.omObject.WaitingForStartTask;
            }
        }
    }
}
