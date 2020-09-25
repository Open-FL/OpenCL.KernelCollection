using System;
using System.Reflection;

using PluginSystem.Core;
using PluginSystem.Core.Interfaces;
using PluginSystem.Core.Pointer;
using PluginSystem.Utility;

using Utility.IO.Callbacks;
using Utility.IO.VirtualFS;

namespace OpenCL.KernelCollection
{
    public class OpenCLKernelCollectionPlugin : APlugin<PluginSystemHost>
    {

        public override bool IsMainPlugin => true;

        public override bool HasIO => true;

        public override string Name => "open-cl-kernel-collection";


        public override void OnLoad(PluginAssemblyPointer ptr)
        {
            base.OnLoad(ptr);

            ManifestReader.RegisterAssembly(Assembly.GetExecutingAssembly());

        }

        public override bool SatisfiesHostType(IPluginHost potentialHost)
        {
            return ManifestReader.IsRegistered(Assembly.GetExecutingAssembly()) && base.SatisfiesHostType(potentialHost);
        }

    }
}
