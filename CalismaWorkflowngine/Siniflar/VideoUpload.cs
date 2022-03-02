using System.Threading;
using CalismaWorkflowEngine.Arayuzler;

namespace CalismaWorkflowEngine.Siniflar
{
    class VideoUpload : IActivity
    {
        public void Execute()
        {
            Upload();
        }

        private void Upload()
        {
            System.Console.WriteLine("Uploading video");
            Thread.Sleep(2000);
            System.Console.WriteLine("Video uploaded");
        }
    }
}