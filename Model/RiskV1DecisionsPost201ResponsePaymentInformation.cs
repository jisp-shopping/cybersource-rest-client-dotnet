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
    /// Contains response information about the payment.
    /// </summary>
    [DataContract]
    public partial class RiskV1DecisionsPost201ResponsePaymentInformation :  IEquatable<RiskV1DecisionsPost201ResponsePaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1DecisionsPost201ResponsePaymentInformation" /> class.
        /// </summary>
        /// <param name="BinCountry">Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="AccountType">Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Issuer">Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Scheme">Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Bin">Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        public RiskV1DecisionsPost201ResponsePaymentInformation(string BinCountry = default(string), string AccountType = default(string), string Issuer = default(string), string Scheme = default(string), string Bin = default(string))
        {
            this.BinCountry = BinCountry;
            this.AccountType = AccountType;
            this.Issuer = Issuer;
            this.Scheme = Scheme;
            this.Bin = Bin;
        }
        
        /// <summary>
        /// Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Country (two-digit country code) associated with the BIN of the customer’s card used for the payment. Returned if the information is available. Use this field for additional information when reviewing orders. This information is also displayed in the details page of the CyberSource Business Center.  For all possible values, see the &#x60;bin_country&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="binCountry", EmitDefaultValue=false)]
        public string BinCountry { get; set; }

        /// <summary>
        /// Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Type of payment card account. This field can refer to a credit card, debit card, or prepaid card account type.  For all possible values, see the &#x60;score_card_account_type&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Name of the bank or entity that issued the card account.  For all possible values, see the &#x60;score_card_issuer&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Subtype of card account. This field can contain one of the following values: - Maestro International - Maestro UK Domestic - MasterCard Credit - MasterCard Debit - Visa Credit - Visa Debit - Visa Electron  **Note** Additional values may be present.  For all possible values, see the &#x60;score_card_scheme&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Credit card BIN (the first six digits of the credit card).Derived either from the &#x60;cc_bin&#x60; request field or from the first six characters of the &#x60;customer_cc_num&#x60; field.  For all possible values, see the &#x60;score_cc_bin&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="bin", EmitDefaultValue=false)]
        public string Bin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1DecisionsPost201ResponsePaymentInformation {\n");
            sb.Append("  BinCountry: ").Append(BinCountry).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
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
            return this.Equals(obj as RiskV1DecisionsPost201ResponsePaymentInformation);
        }

        /// <summary>
        /// Returns true if RiskV1DecisionsPost201ResponsePaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1DecisionsPost201ResponsePaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1DecisionsPost201ResponsePaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BinCountry == other.BinCountry ||
                    this.BinCountry != null &&
                    this.BinCountry.Equals(other.BinCountry)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.Scheme == other.Scheme ||
                    this.Scheme != null &&
                    this.Scheme.Equals(other.Scheme)
                ) && 
                (
                    this.Bin == other.Bin ||
                    this.Bin != null &&
                    this.Bin.Equals(other.Bin)
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
                if (this.BinCountry != null)
                    hash = hash * 59 + this.BinCountry.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.Scheme != null)
                    hash = hash * 59 + this.Scheme.GetHashCode();
                if (this.Bin != null)
                    hash = hash * 59 + this.Bin.GetHashCode();
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
            // BinCountry (string) maxLength
            if(this.BinCountry != null && this.BinCountry.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BinCountry, length must be less than 255.", new [] { "BinCountry" });
            }

            // AccountType (string) maxLength
            if(this.AccountType != null && this.AccountType.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountType, length must be less than 255.", new [] { "AccountType" });
            }

            // Issuer (string) maxLength
            if(this.Issuer != null && this.Issuer.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Issuer, length must be less than 255.", new [] { "Issuer" });
            }

            // Scheme (string) maxLength
            if(this.Scheme != null && this.Scheme.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scheme, length must be less than 255.", new [] { "Scheme" });
            }

            // Bin (string) maxLength
            if(this.Bin != null && this.Bin.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bin, length must be less than 255.", new [] { "Bin" });
            }

            yield break;
        }
    }

}
