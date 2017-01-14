// created on 02-10-2002 at 20:22

// C#
// Create a connection to the queue.
using System.Messaging;
class msg{
	static void Main(){
		MessageQueue mq = new System.Messaging.MessageQueue (@"Posto26\Queue");
		// Send an integer.
		//mq.Send (1);
		// Send a string.
		mq.Send ("Hello world");
		}
}
