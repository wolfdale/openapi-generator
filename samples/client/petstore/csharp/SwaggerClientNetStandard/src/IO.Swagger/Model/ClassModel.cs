/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Model for testing model with \&quot;_class\&quot; property
    /// </summary>
    [DataContract]
    public partial class ClassModel :  IEquatable<ClassModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassModel" /> class.
        /// </summary>
        /// <param name="_Class">_Class.</param>
        public ClassModel(string _Class = default(string))
        {
            this._Class = _Class;
        }
        
        /// <summary>
        /// Gets or Sets _Class
        /// </summary>
        [DataMember(Name="_class", EmitDefaultValue=false)]
        public string _Class { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassModel {\n");
            sb.Append("  _Class: ").Append(_Class).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClassModel);
        }

        /// <summary>
        /// Returns true if ClassModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Class == input._Class ||
                    (this._Class != null &&
                    this._Class.Equals(input._Class))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this._Class != null)
                    hashCode = hashCode * 59 + this._Class.GetHashCode();
                return hashCode;
            }
        }
    }

}
