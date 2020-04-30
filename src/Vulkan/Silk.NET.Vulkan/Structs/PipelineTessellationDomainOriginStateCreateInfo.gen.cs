// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineTessellationDomainOriginStateCreateInfo
    {
        public PipelineTessellationDomainOriginStateCreateInfo
        (
            StructureType sType = StructureType.PipelineTessellationDomainOriginStateCreateInfo,
            void* pNext = default,
            TessellationDomainOrigin domainOrigin = default
        )
        {
           SType = sType;
           PNext = pNext;
           DomainOrigin = domainOrigin;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public TessellationDomainOrigin DomainOrigin;
    }
}