using System;
using Gtk;
using System.Threading;
using System.Text;


using NetMQ;
using NetMQ.Sockets;
using System.ComponentModel;
using Newtonsoft.Json;

//using ServiceStack.Redis;
//using ServiceStack.Text;

public partial class MainWindow : Gtk.Window
{
	ResponseSocket responseSocket;
	RequestSocket requestSocket;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		responseSocket = new ResponseSocket("tcp://*:5556");
		requestSocket = new RequestSocket("tcp://localhost:5555");
			
		BackgroundWorker bw = new BackgroundWorker();

		bw.WorkerReportsProgress = true;

		bw.DoWork += delegate (object o, DoWorkEventArgs args1)
		          {
			          Console.WriteLine("Listening for messages on 5556");

					  while (true)
				    {
				         var message = responseSocket.ReceiveFrameString();

				     //  var message = responseSocket.ReceiveFrameBytes();

					    //object p =  JsonConvert.DeserializeObject(Encoding.UTF8.GetString(message));

						Console.WriteLine("Response socket received:" + message);

				        this.hscale3.Value = Double.Parse(message);

						Console.WriteLine("Response sending back Ack for :" + message);
					    
						responseSocket.SendFrame("Done setting to value " + message);
 				     }
			      };

		bw.RunWorkerAsync();
			
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnHscale3MoveSlider(object o, MoveSliderArgs args)
	{
		Console.WriteLine(args.ToString());
	}

	protected void OnHscale3ValueChanged(object sender, EventArgs e)
	{
		HScale hs = (HScale)sender;
		//Console.WriteLine(hs.Value);

	
		Console.WriteLine("requestSocket : Sending " + hs.Value.ToString());
		requestSocket.SendFrame(hs.Value.ToString());

		var message = requestSocket.ReceiveFrameString();
		Console.WriteLine("requestSocket : Received " + message);
		

		//const string ChannelName = "SimplePubSubCHANNEL";
		//var redisPublisher = new RedisClient();
		//ThreadPool.QueueUserWorkItem(x =>
		//		{
		//			//Thread.Sleep(200);
		//			//Console.WriteLine("Publishing '{0}' to '{1}'", hs.Value, ChannelName);
		//			//redisPublisher.PublishMessage(ChannelName, hs.Value.ToString());
		//});
	}
}

