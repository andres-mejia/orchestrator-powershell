// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores a custom pair of key and value for assets with type
    /// KeyValueList.
    /// </summary>
    public partial class CustomKeyValuePair
    {
        /// <summary>
        /// Initializes a new instance of the CustomKeyValuePair class.
        /// </summary>
        public CustomKeyValuePair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomKeyValuePair class.
        /// </summary>
        /// <param name="key">A piece of text representing the key.</param>
        /// <param name="value">A piece of text representing the value.</param>
        public CustomKeyValuePair(string key = default(string), string value = default(string))
        {
            Key = key;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a piece of text representing the key.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets a piece of text representing the value.
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}