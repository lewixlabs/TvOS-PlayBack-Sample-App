using System;
using UIKit;
using AVKit;
using AVFoundation;


namespace TvOS_PlayBack_Sample_App
{
	public partial class ViewController : UIViewController
	{
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void PlayVideo(UIButton sender)
        {
            var url = new Uri("https://devimages-cdn.apple.com/samplecode/avfoundationMedia/AVFoundationQueuePlayer_HLS2/master.m3u8");
            if (url != null)
            {
                // Create an AVPlayer, passing it the HTTP Live Streaming URL.
                var player = new AVPlayer(url);

                // Create a new AVPlayerViewController and pass it a reference to the player.
                var controller = new AVPlayerViewController();
                controller.Player = player;

                // Modally present the player and call the player's play() method when complete.
                PresentViewController(viewControllerToPresent: controller, true, () => player.Play());
            }
        }
    }
}


