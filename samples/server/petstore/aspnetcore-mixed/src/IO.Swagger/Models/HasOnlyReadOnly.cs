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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class HasOnlyReadOnly : IEquatable<HasOnlyReadOnly>
    { 
        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [DataMember(Name="bar")]
        public string Bar { get; private set; }

        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [DataMember(Name="foo")]
        public string Foo { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HasOnlyReadOnly {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((HasOnlyReadOnly)obj);
        }

        /// <summary>
        /// Returns true if HasOnlyReadOnly instances are equal
        /// </summary>
        /// <param name="other">Instance of HasOnlyReadOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HasOnlyReadOnly other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Bar == other.Bar ||
                    Bar != null &&
                    Bar.Equals(other.Bar)
                ) && 
                (
                    Foo == other.Foo ||
                    Foo != null &&
                    Foo.Equals(other.Foo)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Bar != null)
                    hashCode = hashCode * 59 + Bar.GetHashCode();
                    if (Foo != null)
                    hashCode = hashCode * 59 + Foo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(HasOnlyReadOnly left, HasOnlyReadOnly right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HasOnlyReadOnly left, HasOnlyReadOnly right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}