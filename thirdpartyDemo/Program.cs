using System;
using Gtk;
using ServiceStack.Redis;
using ServiceStack.Text;
using System.Threading;

using NetMQ;
using NetMQ.Sockets;

namespace thirdpartyDemo
{

	class MainClass
	{

		public static void Main(string[] args)
		{
			Application.Init();

			MainWindow win = new MainWindow();

			win.ShowAll();

			//using (var responseSocket = new ResponseSocket("tcp://*:5555"))
			//using (var requestSocket = new RequestSocket("tcp://localhost:5555"))
			//{
			//	//while (true)
			//	{
			//		Console.WriteLine("requestSocket : Sending ");
			//		requestSocket.SendFrame("hello");

			//		var message = requestSocket.ReceiveFrameString();
			//		Console.WriteLine("responseSocket : Server Received '{0}'", message);
			//	}
			//}
			//const string ChannelName = "SimplePubSubCHANNEL";
			//const string MessagePrefix = "MESSAGE ";
			//const int PublishMessageCount = 5;

			//int messagesReceived = 0;

			//using (var redisConsumer = new RedisClient())
			//using (var subscription = redisConsumer.CreateSubscription())
			//{
			//	subscription.OnSubscribe = channel =>
			//	{
			//		Console.WriteLine("Subscribed to '{0}'", channel);
			//	};
			//	subscription.OnUnSubscribe = channel =>
			//	{
			//		Console.WriteLine("UnSubscribed from '{0}'", channel);
			//	};
			//	subscription.OnMessage = (channel, msg) =>
			//	{
			//		Console.WriteLine("Received '{0}' from channel '{1}'", msg, channel);

			//			//As soon as we've received all 5 messages, disconnect by unsubscribing to all channels
			//			if (++messagesReceived == PublishMessageCount)
			//		{
			//			subscription.UnSubscribeFromAllChannels();
			//		}
			//	};

				//ThreadPool.QueueUserWorkItem(x =>
				//{
				//	Thread.Sleep(200);
				//	Console.WriteLine("Begin publishing messages...");

				//	using (var redisPublisher = new RedisClient())
				//	{
				//		for (var i = 1; i <= PublishMessageCount; i++)
				//		{
				//			var message = MessagePrefix + i;
				//			Console.WriteLine("Publishing '{0}' to '{1}'", message, ChannelName);
				//			redisPublisher.PublishMessage(ChannelName, message);
				//		}
				//	}
				//});

				//Console.WriteLine("Started Listening On '{0}'", ChannelName);
				//subscription.SubscribeToChannels(ChannelName); //blocking
			//}
			Application.Run();
		}
	}
}
