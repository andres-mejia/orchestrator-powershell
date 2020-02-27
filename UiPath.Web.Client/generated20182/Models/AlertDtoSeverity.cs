// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AlertDtoSeverity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AlertDtoSeverity
    {
        [EnumMember(Value = "Info")]
        Info,
        [EnumMember(Value = "Success")]
        Success,
        [EnumMember(Value = "Warn")]
        Warn,
        [EnumMember(Value = "Error")]
        Error,
        [EnumMember(Value = "Fatal")]
        Fatal
    }
    internal static class AlertDtoSeverityEnumExtension
    {
        internal static string ToSerializedValue(this AlertDtoSeverity? value)
        {
            return value == null ? null : ((AlertDtoSeverity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AlertDtoSeverity value)
        {
            switch( value )
            {
                case AlertDtoSeverity.Info:
                    return "Info";
                case AlertDtoSeverity.Success:
                    return "Success";
                case AlertDtoSeverity.Warn:
                    return "Warn";
                case AlertDtoSeverity.Error:
                    return "Error";
                case AlertDtoSeverity.Fatal:
                    return "Fatal";
            }
            return null;
        }

        internal static AlertDtoSeverity? ParseAlertDtoSeverity(this string value)
        {
            switch( value )
            {
                case "Info":
                    return AlertDtoSeverity.Info;
                case "Success":
                    return AlertDtoSeverity.Success;
                case "Warn":
                    return AlertDtoSeverity.Warn;
                case "Error":
                    return AlertDtoSeverity.Error;
                case "Fatal":
                    return AlertDtoSeverity.Fatal;
            }
            return null;
        }
    }
}