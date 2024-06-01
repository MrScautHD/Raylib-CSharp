using Raylib_CSharp.Samples;
using Raylib_CSharp.Samples.Core;

List<ISample> samples = new List<ISample>();
samples.Add(new CustomLogger());
samples.Add(new BasicWindow());

foreach (ISample sample in samples) {
    using (sample) {
        sample.Run();
    }
}