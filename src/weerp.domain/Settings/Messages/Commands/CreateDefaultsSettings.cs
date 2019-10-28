using System;

namespace weerp.domain.Settings.Messages.Commands
{
    public class CreateDefaultsSettings : SettingBaseCommand
    {
        public CreateDefaultsSettings(Guid id,string description)
        {
            Id = id;
            this.Description = description;
        }

        public override Guid Id { get ; set ; }
        public string Description { get; }
    }
}
