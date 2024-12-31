using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace JitsiVideoCalling
{
    public class VideoCallHub : Hub
    {
        private readonly ILogger<VideoCallHub> _logger;

        public VideoCallHub(ILogger<VideoCallHub> logger)
        {
            _logger = logger;
        }
        // Define a static admin ID
        //private const string adminId = "anuj1902";
        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");


        //    // Notify the admin about the video call request
        //    await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //}
        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        using (var client = new WebClient())
        //        {
        //            // Asynchronously download the string content from the URL
        //            var content = await client.DownloadStringTaskAsync(jitsiRoomUrl);
        //            _logger.LogInformation($"Downloaded String: {content}");
        //        }

        //        // Notify the admin about the video call request
        //        await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}
        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        //using (var client = new WebClient())
        //        //{
        //        //    // Asynchronously download the string content from the URL
        //        //    var content = await client.DownloadStringTaskAsync(jitsiRoomUrl);
        //        //    _logger.LogInformation($"Downloaded String: {content}");
        //        //}
        //        System.Diagnostics.Process.Start("http://google.com");
        //        //using (var client = new WebClient())
        //        //{
        //        //    // Asynchronously download the string content from the URL
        //        //    var content = await client.;
        //        //    _logger.LogInformation($"Downloaded String: {content}");
        //        //}
        //        // Check if the connection has a value
        //        if (Context.ConnectionId != null)
        //        {
        //            // Notify the admin about the video call request
        //            await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);

        //            _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Connection does not have a value.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}

        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        System.Diagnostics.Process.Start("http://google.com");
        //        // Check if the connection has a value
        //        if (Context.ConnectionId != null)
        //        {
        //            // Notify the admin about the video call request
        //            await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //            _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Connection does not have a value.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}
        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        // Open the URL in the default browser
        //        var psi = new ProcessStartInfo
        //        {
        //            FileName = "https://google.com",
        //            UseShellExecute = true // Open the URL using the default browser
        //        };
        //        Process.Start(psi);

        //        // Check if the connection has a value
        //        if (Context.ConnectionId != null)
        //        {
        //            // Notify the admin about the video call request
        //            await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //            _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Connection does not have a value.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}


        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");
        //    try
        //    {               
        //        // Check if the connection has a value
        //        if (Context.ConnectionId != null)
        //        {
        //            // Notify the admin about the video call request
        //            await Clients.User(adminId).SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //            _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Connection does not have a value.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}

        //public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        //{
        //    // Log the video call initiation
        //    _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        // Check if the connection has a value
        //        if (Context.ConnectionId != null)
        //        {
        //            // Notify the admin about the video call request and send the path to index.html
        //            await Clients.User(adminId).SendAsync("ReceiveCallNotification", "/path/to/index.html");
        //            _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
        //        }
        //        else
        //        {
        //            _logger.LogWarning("Connection does not have a value.");
        //        }
        //        using (var client = new HttpClient())
        //        {
        //            await client.GetAsync("https://google.com");
        //        }               
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}
        //public async Task InitiateVideoCall(string jitsiRoomUrl)
        //{
        //    _logger.LogInformation($"Video call initiated with Jitsi room URL: {jitsiRoomUrl}");

        //    try
        //    {
        //        // Notify all connected clients about the video call request with the URL
        //        await Clients.All.SendAsync("ReceiveCallNotification", jitsiRoomUrl);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "An error occurred while initiating the video call.");
        //    }
        //}
        public async Task InitiateVideoCall(string adminId, string jitsiRoomUrl)
        {
            // Log the video call initiation
            _logger.LogInformation($"Video call initiated for adminId: {adminId} with Jitsi room URL: {jitsiRoomUrl}");

            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "http://google.com",
                    UseShellExecute = true
                });
                // Check if the connection has a value
                if (Context.ConnectionId != null)
                {
                    // Notify the admin about the video call request and send the path to index.html
                    await Clients.User(adminId).SendAsync("ReceiveCallNotification", "/path/to/index.html");
                    _logger.LogInformation($"Connection has value: {Context.ConnectionId}");
                }
                else
                {
                    _logger.LogWarning("Connection does not have a value.");
                }
                //using (var client = new HttpClient())
                //{
                //    await client.GetAsync("https://google.com");
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initiating the video call.");
            }
        }
        public async Task AcceptCall(string jitsiRoomUrl)
        {
            // Log the video call acceptance
            _logger.LogInformation($"Video call accepted for Jitsi room URL: {jitsiRoomUrl}");

            // Notify the caller that the call has been accepted
            await Clients.All.SendAsync("CallAccepted", jitsiRoomUrl);
        }

        public async Task RejectCall(string jitsiRoomUrl)
        {
            // Log the video call rejection
            _logger.LogInformation($"Video call rejected for Jitsi room URL: {jitsiRoomUrl}");

            // Notify the caller that the call has been rejected
            await Clients.All.SendAsync("CallRejected", jitsiRoomUrl);
        }
    }
}
