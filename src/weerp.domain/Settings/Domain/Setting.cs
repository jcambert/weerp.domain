﻿using MicroS_Common.Types;
using System;

namespace weerp.domain.Settings.Domain
{
    public class Setting : BaseEntity
    {
        private string _desc;
        private int _numero;
        private string _categorie;
        private string _type;
        private string _stringValue;
        private int? _intValue;
        private object _doubleValue;

        public Setting(Guid id,
            int numero,
            string categorie,
            string description,
            string type,
            string stringValue,
            int? intValue,
            double? doubleValue,
            DateTime? dtValue) : base(id)
        {
            SetNumero(numero);
            SetCategorie(categorie);
            SetDescription(description);
            SetType(type);
            SetStringValue(stringValue);
            SetIntValue(intValue);
            SetDoubleValue(doubleValue);
            SetDateTimeValue(dtValue);
        }

        private void SetCategorie(string categorie) => this.SetProperty(ref _categorie, categorie,  () => this.SetUpdatedDate());

        private void SetDateTimeValue(DateTime? dtValue)
        {

        }

        private void SetDoubleValue(double? doubleValue) => this.SetProperty(ref _doubleValue, doubleValue, () => this.SetUpdatedDate());

        private void SetIntValue(int? intValue) => this.SetProperty(ref _intValue, intValue, () => this.SetUpdatedDate());

        private void SetStringValue(string stringValue) => this.SetProperty(ref _stringValue, stringValue, () => this.SetUpdatedDate());

        private void SetType(string type) => this.SetProperty(ref _type, type?.Trim()?.ToLowerInvariant(),  () => this.SetUpdatedDate());

        private void SetDescription(string desc) => this.SetProperty(ref _desc, desc?.Trim()?.ToLowerInvariant(), () => this.SetUpdatedDate());

        private void SetNumero(int numero) => this.SetProperty(ref _numero, numero, () => this.SetUpdatedDate());

        public int Numero { get => _numero; private set { _numero = value; } }

        public string Categorie { get => _categorie; private set { _categorie = value; } }

        public string Description { get => _desc; private set { _desc = value; } }

        public string Type { get => _type; private set { _type = value; } }

        public string StringValue { get => _stringValue; private set { _stringValue = value; } }

        public int? IntegerValue { get => _intValue; private set { _intValue = value; } }

        public double? DoubleValue { get; private set; }

        public DateTime? DateValue { get; private set; }

    }
}
