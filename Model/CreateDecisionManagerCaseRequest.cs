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
    /// CreateDecisionManagerCaseRequest
    /// </summary>
    [DataContract]
    public partial class CreateDecisionManagerCaseRequest :  IEquatable<CreateDecisionManagerCaseRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDecisionManagerCaseRequest" /> class.
        /// </summary>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="CardVerification">CardVerification.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="TravelInformation">TravelInformation.</param>
        /// <param name="MerchantDefinedInformation">MerchantDefinedInformation.</param>
        public CreateDecisionManagerCaseRequest(Riskv1decisionsClientReferenceInformation ClientReferenceInformation = default(Riskv1decisionsClientReferenceInformation), Riskv1decisionsProcessorInformation ProcessorInformation = default(Riskv1decisionsProcessorInformation), Riskv1decisionsPaymentInformation PaymentInformation = default(Riskv1decisionsPaymentInformation), Riskv1decisionsOrderInformation OrderInformation = default(Riskv1decisionsOrderInformation), Riskv1decisionsBuyerInformation BuyerInformation = default(Riskv1decisionsBuyerInformation), Riskv1decisionsDeviceInformation DeviceInformation = default(Riskv1decisionsDeviceInformation), Riskv1decisionsCardVerification CardVerification = default(Riskv1decisionsCardVerification), Riskv1decisionsRiskInformation RiskInformation = default(Riskv1decisionsRiskInformation), Riskv1decisionsTravelInformation TravelInformation = default(Riskv1decisionsTravelInformation), List<Riskv1decisionsMerchantDefinedInformation> MerchantDefinedInformation = default(List<Riskv1decisionsMerchantDefinedInformation>))
        {
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ProcessorInformation = ProcessorInformation;
            this.PaymentInformation = PaymentInformation;
            this.OrderInformation = OrderInformation;
            this.BuyerInformation = BuyerInformation;
            this.DeviceInformation = DeviceInformation;
            this.CardVerification = CardVerification;
            this.RiskInformation = RiskInformation;
            this.TravelInformation = TravelInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
        }
        
        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Riskv1decisionsClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public Riskv1decisionsProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public Riskv1decisionsPaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Riskv1decisionsBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public Riskv1decisionsDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets CardVerification
        /// </summary>
        [DataMember(Name="cardVerification", EmitDefaultValue=false)]
        public Riskv1decisionsCardVerification CardVerification { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public Riskv1decisionsRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets TravelInformation
        /// </summary>
        [DataMember(Name="travelInformation", EmitDefaultValue=false)]
        public Riskv1decisionsTravelInformation TravelInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantDefinedInformation
        /// </summary>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<Riskv1decisionsMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDecisionManagerCaseRequest {\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  CardVerification: ").Append(CardVerification).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  TravelInformation: ").Append(TravelInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
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
            return this.Equals(obj as CreateDecisionManagerCaseRequest);
        }

        /// <summary>
        /// Returns true if CreateDecisionManagerCaseRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateDecisionManagerCaseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDecisionManagerCaseRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.CardVerification == other.CardVerification ||
                    this.CardVerification != null &&
                    this.CardVerification.Equals(other.CardVerification)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.TravelInformation == other.TravelInformation ||
                    this.TravelInformation != null &&
                    this.TravelInformation.Equals(other.TravelInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
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
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.CardVerification != null)
                    hash = hash * 59 + this.CardVerification.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.TravelInformation != null)
                    hash = hash * 59 + this.TravelInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
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
            yield break;
        }
    }

}