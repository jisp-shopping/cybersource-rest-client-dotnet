/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2paymentsMerchantInformationMerchantDescriptor
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsMerchantInformationMerchantDescriptor :  IEquatable<Ptsv2paymentsMerchantInformationMerchantDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsMerchantInformationMerchantDescriptor" /> class.
        /// </summary>
        /// <param name="Name">Merchant&#39;s name.  For more details about the merchant-related fields, see the &#x60;merchant_descriptor&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22. .</param>
        /// <param name="AlternateName">An alternate name for the merchant.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_alternate&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; .</param>
        /// <param name="Contact">For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_contact&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; Contact information for the merchant.  **Note** These are the maximum data lengths for the following payment processors: - FDCCompass (13) - Paymentech (13) .</param>
        /// <param name="Address1">First line of merchant&#39;s address. For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_street&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Locality">Merchant&#39;s City.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_city&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Country">Merchant&#39;s country.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_country&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="PostalCode">Merchant&#39;s postal code.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_postal_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="AdministrativeArea">The state where the merchant is located.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_state&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Merchant State. For the descriptions, used-by information, data types, and lengths for these fields, see Merchant Descriptors in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        public Ptsv2paymentsMerchantInformationMerchantDescriptor(string Name = default(string), string AlternateName = default(string), string Contact = default(string), string Address1 = default(string), string Locality = default(string), string Country = default(string), string PostalCode = default(string), string AdministrativeArea = default(string))
        {
            this.Name = Name;
            this.AlternateName = AlternateName;
            this.Contact = Contact;
            this.Address1 = Address1;
            this.Locality = Locality;
            this.Country = Country;
            this.PostalCode = PostalCode;
            this.AdministrativeArea = AdministrativeArea;
        }
        
        /// <summary>
        /// Merchant&#39;s name.  For more details about the merchant-related fields, see the &#x60;merchant_descriptor&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22. 
        /// </summary>
        /// <value>Merchant&#39;s name.  For more details about the merchant-related fields, see the &#x60;merchant_descriptor&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  **Note** For Paymentech processor using Cybersource Payouts, the maximum data length is 22. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An alternate name for the merchant.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_alternate&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; 
        /// </summary>
        /// <value>An alternate name for the merchant.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_alternate&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; </value>
        [DataMember(Name="alternateName", EmitDefaultValue=false)]
        public string AlternateName { get; set; }

        /// <summary>
        /// For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_contact&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; Contact information for the merchant.  **Note** These are the maximum data lengths for the following payment processors: - FDCCompass (13) - Paymentech (13) 
        /// </summary>
        /// <value>For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_contact&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)- -&gt; Contact information for the merchant.  **Note** These are the maximum data lengths for the following payment processors: - FDCCompass (13) - Paymentech (13) </value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// First line of merchant&#39;s address. For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_street&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>First line of merchant&#39;s address. For the descriptions, used-by information, data types, and lengths for these fields, see &#x60;merchant_descriptor_street&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Merchant&#39;s City.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_city&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Merchant&#39;s City.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_city&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Merchant&#39;s country.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_country&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Merchant&#39;s country.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_country&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Merchant&#39;s postal code.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_postal_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Merchant&#39;s postal code.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_postal_code&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state where the merchant is located.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_state&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Merchant State. For the descriptions, used-by information, data types, and lengths for these fields, see Merchant Descriptors in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>The state where the merchant is located.  For the descriptions, used-by information, data types, and lengths for these fields, see the &#x60;merchant_descriptor_state&#x60; field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html)  Merchant State. For the descriptions, used-by information, data types, and lengths for these fields, see Merchant Descriptors in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsMerchantInformationMerchantDescriptor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Ptsv2paymentsMerchantInformationMerchantDescriptor);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsMerchantInformationMerchantDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsMerchantInformationMerchantDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsMerchantInformationMerchantDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AlternateName == other.AlternateName ||
                    this.AlternateName != null &&
                    this.AlternateName.Equals(other.AlternateName)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AlternateName != null)
                    hash = hash * 59 + this.AlternateName.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AlternateName (string) maxLength
            if(this.AlternateName != null && this.AlternateName.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AlternateName, length must be less than 13.", new [] { "AlternateName" });
            }

            // Contact (string) maxLength
            if(this.Contact != null && this.Contact.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contact, length must be less than 14.", new [] { "Contact" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 60.", new [] { "Address1" });
            }

            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than 13.", new [] { "Locality" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 2.", new [] { "Country" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 14.", new [] { "PostalCode" });
            }

            // AdministrativeArea (string) maxLength
            if(this.AdministrativeArea != null && this.AdministrativeArea.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, length must be less than 3.", new [] { "AdministrativeArea" });
            }

            yield break;
        }
    }

}
