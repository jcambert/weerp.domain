using System;
using System.Collections.Generic;
using weerp.domain.Settings.Dto;

namespace weerp.domain.Settings
{
    public static class DefaultsSettings
    {
        public static List<SettingDto> Get =>
            new List<SettingDto>()
            {
                #region Paramtres Generaux
                new SettingDto() {Id=Guid.NewGuid(),Numero=1,Type="A",Category="General", Description="Nom Entreprise"},
                new SettingDto() {Id=Guid.NewGuid(),Numero=2,Type="A",Category="General",Description="Logo"},
                new SettingDto() {Id=Guid.NewGuid(),Numero=3,Type="A",Category="General",Description="Adresse"},
                #endregion

            };

    }
}
