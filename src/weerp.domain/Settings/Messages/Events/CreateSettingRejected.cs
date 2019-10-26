using MicroS_Common.Messages;
using System;

namespace weerp.domain.Settings.Messages.Events
{
    public class CreateSettingRejected : BaseRejectedEvent
    {
        public CreateSettingRejected(Guid id, string reason, string code) : base(id, reason, code)
        {
        }
    }
}
