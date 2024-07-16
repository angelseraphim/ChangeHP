using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChangeHP
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Role and HP")]
        public Dictionary<RoleTypeId, int> HPVal { get; set; } = new Dictionary<RoleTypeId, int>()
        {
            {RoleTypeId.Scp939, 3000},
            {RoleTypeId.NtfCaptain, 120}
        };
    }
}
