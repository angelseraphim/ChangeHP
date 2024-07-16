using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace ChangeHP
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "ChangeHP";
        public override string Name => "ChangeHP";
        public override string Author => "angelseraphim.";
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole += OnChangingRole;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= OnChangingRole;
            base.OnDisabled();
        }
        private void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (Config.HPVal.ContainsKey(ev.NewRole))
            {
                ev.Player.MaxHealth = Config.HPVal[ev.NewRole];
                ev.Player.Health = Config.HPVal[ev.NewRole];
            }
        }
    }
}
