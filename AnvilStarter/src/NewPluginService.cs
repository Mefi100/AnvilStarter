using Anvil.API;
using Anvil.API.Events;
using Anvil.Services;

namespace AnvilStarter
{
    [ServiceBinding(typeof(NewPluginService))]
    public class NewPluginService
    {
        public NewPluginService()
        {
            NwModule.Instance.OnClientEnter += HelloWorld;
        }

        private void HelloWorld(ModuleEvents.OnClientEnter evt)
        {
            evt.Player.SendServerMessage("Hello world", ColorConstants.Lime);
        }
    }
}