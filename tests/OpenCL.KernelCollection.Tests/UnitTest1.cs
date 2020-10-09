using NUnit.Framework;

using OpenCL.KernelCollection;
using OpenCL.Wrapper;
using OpenCL.Wrapper.TypeEnums;

using Utility.IO.VirtualFS;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ManifestReader.RegisterAssembly(typeof(OpenCLKernelCollectionPlugin).Assembly);
            EmbeddedFileIOManager.Initialize();
        }

        [Test]
        public void CompileTest()
        {
            CLAPI instance = CLAPI.GetInstance();
            KernelDatabase db = new KernelDatabase(instance, "resources/kernel", DataVectorTypes.Uchar1);

            Assert.True(db.KernelNames.Count != 0);
            Assert.Pass("Kernels Loaded: " + db.KernelNames.Count);
            db.Dispose();
            instance.Dispose();
        }
    }
}