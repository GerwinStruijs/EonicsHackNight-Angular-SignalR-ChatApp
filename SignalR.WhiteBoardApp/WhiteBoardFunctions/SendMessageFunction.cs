using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;

namespace WhiteBoardFunctions
{
	public static class SendMessageFunction
	{
		[FunctionName("SendMessage")]
		public static Task SendMessage(
			[HttpTrigger(AuthorizationLevel.Anonymous, "post")]
			Message message,
			[SignalR(HubName = "whiteboard")] IAsyncCollector<SignalRMessage> signalRMessages)
		{
			if (message == null) return null;

			if (string.IsNullOrEmpty(message.UserId)) return null;

			return signalRMessages.AddAsync(
				new SignalRMessage
				{
					// the message will only be sent to this user ID
					UserId = message.UserId,
					Target = "ReceiveMessage",
					Arguments = new object[] { message }
				});
		}
	}
}
