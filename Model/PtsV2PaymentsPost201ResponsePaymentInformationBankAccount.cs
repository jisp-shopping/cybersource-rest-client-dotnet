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
    /// PtsV2PaymentsPost201ResponsePaymentInformationBankAccount
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInformationBankAccount :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInformationBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInformationBankAccount" /> class.
        /// </summary>
        /// <param name="CorrectedAccountNumber">Corrected account number from the ACH verification service.  For details, see &#x60;ecp_debit_corrected_account_number&#x60; or &#x60;ecp_credit_corrected_account_number&#x60; field descriptions in [Electronic Check Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        public PtsV2PaymentsPost201ResponsePaymentInformationBankAccount(string CorrectedAccountNumber = default(string))
        {
            this.CorrectedAccountNumber = CorrectedAccountNumber;
        }
        
        /// <summary>
        /// Corrected account number from the ACH verification service.  For details, see &#x60;ecp_debit_corrected_account_number&#x60; or &#x60;ecp_credit_corrected_account_number&#x60; field descriptions in [Electronic Check Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Corrected account number from the ACH verification service.  For details, see &#x60;ecp_debit_corrected_account_number&#x60; or &#x60;ecp_credit_corrected_account_number&#x60; field descriptions in [Electronic Check Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="correctedAccountNumber", EmitDefaultValue=false)]
        public string CorrectedAccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInformationBankAccount {\n");
            sb.Append("  CorrectedAccountNumber: ").Append(CorrectedAccountNumber).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInformationBankAccount);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInformationBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInformationBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInformationBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CorrectedAccountNumber == other.CorrectedAccountNumber ||
                    this.CorrectedAccountNumber != null &&
                    this.CorrectedAccountNumber.Equals(other.CorrectedAccountNumber)
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
                if (this.CorrectedAccountNumber != null)
                    hash = hash * 59 + this.CorrectedAccountNumber.GetHashCode();
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
            // CorrectedAccountNumber (string) maxLength
            if(this.CorrectedAccountNumber != null && this.CorrectedAccountNumber.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CorrectedAccountNumber, length must be less than 17.", new [] { "CorrectedAccountNumber" });
            }

            yield break;
        }
    }

}
