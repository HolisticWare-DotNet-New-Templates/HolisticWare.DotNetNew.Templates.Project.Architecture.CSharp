namespace ProjectsStructureTemplate.Servers.MicroService.SignalR.Hubs
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR;

    public partial class
                                            Chat
                                            :
                                            Microsoft.AspNetCore.SignalR.Hub
    {
        public async
            Task
                                            SendMessage
                                            (
                                                string user,
                                                string message
                                            )
        {
            Trace.WriteLine("Received message, sending back echo");

            /*  
             Error CS1061:
             'IClientProxy' does not contain a definition for 'SendAsync' and no accessible extension method
             'SendAsync' accepting a first argument of type 'IClientProxy' could be found
             (are you missing a using directive or an assembly reference?)
            */
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            return;
        }
    }
}