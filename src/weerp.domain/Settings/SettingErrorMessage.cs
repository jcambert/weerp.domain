using MicroS_Common.Messages;
using MicroS_Common.Types;
using System;
using System.Collections.Generic;
using weerp.domain.Settings.Domain;

namespace weerp.domain.Settings
{
    public class SettingErrorMessage
    {
        private static readonly string CODE = "validation_error";

        public static readonly ErrorMessage SETTING_ALREADY_EXIST = new ErrorMessage() { Code = "setting_already_exists", Message = "Setting: '{0}' already exists." };
        public static readonly ErrorMessage SETTING_NUMBER_POSITIVE = new ErrorMessage() { Code = "Setting number cannot be negative" };
        public static readonly ErrorMessage SETTING_CATEGORY_NEEDED = new ErrorMessage() { Code = "setting_category_empty", Message = "Setting: '0' a category is needed" };
        public static readonly ErrorMessage SETTING_DESCRIPTION_NEEDED = new ErrorMessage() { Code = "setting_description_empty", Message = "Setting: '0' description cannot be empty." };
        public static readonly ErrorMessage SETTING_TYPE_NEEDED = new ErrorMessage() { Code = "setting_type_empty", Message = "Setting: '0' type cannot be empty." };
        private readonly List<string> messages = new List<string>();
        public SettingErrorMessage()
        {

        }
        public void Add(ErrorMessage message, params string[] args)
        {
            this.messages.Add($"Code:{message.Code },Message:{String.Format(message.Message, args)}");
        }

        public void Throw()
        {
            if (this.messages.Count == 0) return;
            throw new MicroSException(CODE, string.Join("*", messages));
        }

        public void AddIf(Func<bool> fn, ErrorMessage message, params string[] args)
        {
            if (fn())
                Add(message, args);
        }
    }
}
