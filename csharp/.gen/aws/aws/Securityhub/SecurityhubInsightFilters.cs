using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFilters")]
    public class SecurityhubInsightFilters : aws.Securityhub.ISecurityhubInsightFilters
    {
        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#aws_account_id SecurityhubInsight#aws_account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersAwsAccountId[]? AwsAccountId
        {
            get;
            set;
        }

        /// <summary>company_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#company_name SecurityhubInsight#company_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersCompanyName[]? CompanyName
        {
            get;
            set;
        }

        /// <summary>compliance_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#compliance_status SecurityhubInsight#compliance_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "complianceStatus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersComplianceStatus[]? ComplianceStatus
        {
            get;
            set;
        }

        /// <summary>confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#confidence SecurityhubInsight#confidence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confidence", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersConfidence[]? Confidence
        {
            get;
            set;
        }

        /// <summary>created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#created_at SecurityhubInsight#created_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersCreatedAt[]? CreatedAt
        {
            get;
            set;
        }

        /// <summary>criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#criticality SecurityhubInsight#criticality}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "criticality", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersCriticality[]? Criticality
        {
            get;
            set;
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#description SecurityhubInsight#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersDescription[]? Description
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_confidence SecurityhubInsight#finding_provider_fields_confidence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsConfidence", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsConfidence[]? FindingProviderFieldsConfidence
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_criticality SecurityhubInsight#finding_provider_fields_criticality}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsCriticality", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsCriticality[]? FindingProviderFieldsCriticality
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_related_findings_id SecurityhubInsight#finding_provider_fields_related_findings_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId[]? FindingProviderFieldsRelatedFindingsId
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_related_findings_product_arn SecurityhubInsight#finding_provider_fields_related_findings_product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn[]? FindingProviderFieldsRelatedFindingsProductArn
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_severity_label SecurityhubInsight#finding_provider_fields_severity_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityLabel", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel[]? FindingProviderFieldsSeverityLabel
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_severity_original block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_severity_original SecurityhubInsight#finding_provider_fields_severity_original}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityOriginal", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal[]? FindingProviderFieldsSeverityOriginal
        {
            get;
            set;
        }

        /// <summary>finding_provider_fields_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#finding_provider_fields_types SecurityhubInsight#finding_provider_fields_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsTypes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFindingProviderFieldsTypes[]? FindingProviderFieldsTypes
        {
            get;
            set;
        }

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#first_observed_at SecurityhubInsight#first_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersFirstObservedAt[]? FirstObservedAt
        {
            get;
            set;
        }

        /// <summary>generator_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#generator_id SecurityhubInsight#generator_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generatorId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersGeneratorId[]? GeneratorId
        {
            get;
            set;
        }

        /// <summary>id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#id SecurityhubInsight#id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersId[]? Id
        {
            get;
            set;
        }

        /// <summary>keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#keyword SecurityhubInsight#keyword}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyword", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersKeyword[]? Keyword
        {
            get;
            set;
        }

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#last_observed_at SecurityhubInsight#last_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersLastObservedAt[]? LastObservedAt
        {
            get;
            set;
        }

        /// <summary>malware_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#malware_name SecurityhubInsight#malware_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersMalwareName[]? MalwareName
        {
            get;
            set;
        }

        /// <summary>malware_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#malware_path SecurityhubInsight#malware_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwarePath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersMalwarePath[]? MalwarePath
        {
            get;
            set;
        }

        /// <summary>malware_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#malware_state SecurityhubInsight#malware_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareState", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersMalwareState[]? MalwareState
        {
            get;
            set;
        }

        /// <summary>malware_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#malware_type SecurityhubInsight#malware_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersMalwareType[]? MalwareType
        {
            get;
            set;
        }

        /// <summary>network_destination_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_destination_domain SecurityhubInsight#network_destination_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationDomain", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkDestinationDomain[]? NetworkDestinationDomain
        {
            get;
            set;
        }

        /// <summary>network_destination_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_destination_ipv4 SecurityhubInsight#network_destination_ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkDestinationIpv4[]? NetworkDestinationIpv4
        {
            get;
            set;
        }

        /// <summary>network_destination_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_destination_ipv6 SecurityhubInsight#network_destination_ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkDestinationIpv6[]? NetworkDestinationIpv6
        {
            get;
            set;
        }

        /// <summary>network_destination_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_destination_port SecurityhubInsight#network_destination_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationPort", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkDestinationPort[]? NetworkDestinationPort
        {
            get;
            set;
        }

        /// <summary>network_direction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_direction SecurityhubInsight#network_direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDirection", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkDirection[]? NetworkDirection
        {
            get;
            set;
        }

        /// <summary>network_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_protocol SecurityhubInsight#network_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkProtocol[]? NetworkProtocol
        {
            get;
            set;
        }

        /// <summary>network_source_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_source_domain SecurityhubInsight#network_source_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceDomain", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkSourceDomain[]? NetworkSourceDomain
        {
            get;
            set;
        }

        /// <summary>network_source_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_source_ipv4 SecurityhubInsight#network_source_ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv4", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkSourceIpv4[]? NetworkSourceIpv4
        {
            get;
            set;
        }

        /// <summary>network_source_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_source_ipv6 SecurityhubInsight#network_source_ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv6", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkSourceIpv6[]? NetworkSourceIpv6
        {
            get;
            set;
        }

        /// <summary>network_source_mac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_source_mac SecurityhubInsight#network_source_mac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceMac", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkSourceMac[]? NetworkSourceMac
        {
            get;
            set;
        }

        /// <summary>network_source_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#network_source_port SecurityhubInsight#network_source_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourcePort", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNetworkSourcePort[]? NetworkSourcePort
        {
            get;
            set;
        }

        /// <summary>note_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#note_text SecurityhubInsight#note_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteText", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNoteText[]? NoteText
        {
            get;
            set;
        }

        /// <summary>note_updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#note_updated_at SecurityhubInsight#note_updated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNoteUpdatedAt[]? NoteUpdatedAt
        {
            get;
            set;
        }

        /// <summary>note_updated_by block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#note_updated_by SecurityhubInsight#note_updated_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersNoteUpdatedBy[]? NoteUpdatedBy
        {
            get;
            set;
        }

        /// <summary>process_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_launched_at SecurityhubInsight#process_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processLaunchedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessLaunchedAt[]? ProcessLaunchedAt
        {
            get;
            set;
        }

        /// <summary>process_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_name SecurityhubInsight#process_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessName[]? ProcessName
        {
            get;
            set;
        }

        /// <summary>process_parent_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_parent_pid SecurityhubInsight#process_parent_pid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processParentPid", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessParentPid[]? ProcessParentPid
        {
            get;
            set;
        }

        /// <summary>process_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_path SecurityhubInsight#process_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processPath", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessPath[]? ProcessPath
        {
            get;
            set;
        }

        /// <summary>process_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_pid SecurityhubInsight#process_pid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processPid", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessPid[]? ProcessPid
        {
            get;
            set;
        }

        /// <summary>process_terminated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#process_terminated_at SecurityhubInsight#process_terminated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processTerminatedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProcessTerminatedAt[]? ProcessTerminatedAt
        {
            get;
            set;
        }

        /// <summary>product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#product_arn SecurityhubInsight#product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productArn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProductArn[]? ProductArn
        {
            get;
            set;
        }

        /// <summary>product_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#product_fields SecurityhubInsight#product_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProductFields[]? ProductFields
        {
            get;
            set;
        }

        /// <summary>product_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#product_name SecurityhubInsight#product_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersProductName[]? ProductName
        {
            get;
            set;
        }

        /// <summary>recommendation_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#recommendation_text SecurityhubInsight#recommendation_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationText", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersRecommendationText[]? RecommendationText
        {
            get;
            set;
        }

        /// <summary>record_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#record_state SecurityhubInsight#record_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordState", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersRecordState[]? RecordState
        {
            get;
            set;
        }

        /// <summary>related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#related_findings_id SecurityhubInsight#related_findings_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersRelatedFindingsId[]? RelatedFindingsId
        {
            get;
            set;
        }

        /// <summary>related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#related_findings_product_arn SecurityhubInsight#related_findings_product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersRelatedFindingsProductArn[]? RelatedFindingsProductArn
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_iam_instance_profile_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_iam_instance_profile_arn SecurityhubInsight#resource_aws_ec2_instance_iam_instance_profile_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn[]? ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_image_id SecurityhubInsight#resource_aws_ec2_instance_image_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceImageId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId[]? ResourceAwsEc2InstanceImageId
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_ipv4_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_ipv4_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv4_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv4Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses[]? ResourceAwsEc2InstanceIpv4Addresses
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_ipv6_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_ipv6_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv6_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses[]? ResourceAwsEc2InstanceIpv6Addresses
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_key_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_key_name SecurityhubInsight#resource_aws_ec2_instance_key_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceKeyName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName[]? ResourceAwsEc2InstanceKeyName
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_launched_at SecurityhubInsight#resource_aws_ec2_instance_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt[]? ResourceAwsEc2InstanceLaunchedAt
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_subnet_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_subnet_id SecurityhubInsight#resource_aws_ec2_instance_subnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceSubnetId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId[]? ResourceAwsEc2InstanceSubnetId
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_type SecurityhubInsight#resource_aws_ec2_instance_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceType[]? ResourceAwsEc2InstanceType
        {
            get;
            set;
        }

        /// <summary>resource_aws_ec2_instance_vpc_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_ec2_instance_vpc_id SecurityhubInsight#resource_aws_ec2_instance_vpc_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceVpcId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId[]? ResourceAwsEc2InstanceVpcId
        {
            get;
            set;
        }

        /// <summary>resource_aws_iam_access_key_created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_iam_access_key_created_at SecurityhubInsight#resource_aws_iam_access_key_created_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt[]? ResourceAwsIamAccessKeyCreatedAt
        {
            get;
            set;
        }

        /// <summary>resource_aws_iam_access_key_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_iam_access_key_status SecurityhubInsight#resource_aws_iam_access_key_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyStatus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus[]? ResourceAwsIamAccessKeyStatus
        {
            get;
            set;
        }

        /// <summary>resource_aws_iam_access_key_user_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_iam_access_key_user_name SecurityhubInsight#resource_aws_iam_access_key_user_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyUserName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName[]? ResourceAwsIamAccessKeyUserName
        {
            get;
            set;
        }

        /// <summary>resource_aws_s3_bucket_owner_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_s3_bucket_owner_id SecurityhubInsight#resource_aws_s3_bucket_owner_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId[]? ResourceAwsS3BucketOwnerId
        {
            get;
            set;
        }

        /// <summary>resource_aws_s3_bucket_owner_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_aws_s3_bucket_owner_name SecurityhubInsight#resource_aws_s3_bucket_owner_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName[]? ResourceAwsS3BucketOwnerName
        {
            get;
            set;
        }

        /// <summary>resource_container_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_container_image_id SecurityhubInsight#resource_container_image_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceContainerImageId[]? ResourceContainerImageId
        {
            get;
            set;
        }

        /// <summary>resource_container_image_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_container_image_name SecurityhubInsight#resource_container_image_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceContainerImageName[]? ResourceContainerImageName
        {
            get;
            set;
        }

        /// <summary>resource_container_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_container_launched_at SecurityhubInsight#resource_container_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerLaunchedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceContainerLaunchedAt[]? ResourceContainerLaunchedAt
        {
            get;
            set;
        }

        /// <summary>resource_container_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_container_name SecurityhubInsight#resource_container_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerName", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceContainerName[]? ResourceContainerName
        {
            get;
            set;
        }

        /// <summary>resource_details_other block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_details_other SecurityhubInsight#resource_details_other}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceDetailsOther[]? ResourceDetailsOther
        {
            get;
            set;
        }

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_id SecurityhubInsight#resource_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceId[]? ResourceId
        {
            get;
            set;
        }

        /// <summary>resource_partition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_partition SecurityhubInsight#resource_partition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePartition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourcePartition[]? ResourcePartition
        {
            get;
            set;
        }

        /// <summary>resource_region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_region SecurityhubInsight#resource_region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRegion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceRegion[]? ResourceRegion
        {
            get;
            set;
        }

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_tags SecurityhubInsight#resource_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTags", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceTags[]? ResourceTags
        {
            get;
            set;
        }

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#resource_type SecurityhubInsight#resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceType[]? ResourceType
        {
            get;
            set;
        }

        /// <summary>severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#severity_label SecurityhubInsight#severity_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severityLabel", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersSeverityLabel[]? SeverityLabel
        {
            get;
            set;
        }

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#source_url SecurityhubInsight#source_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersSourceUrl[]? SourceUrl
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_category SecurityhubInsight#threat_intel_indicator_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorCategory", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorCategory[]? ThreatIntelIndicatorCategory
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_last_observed_at SecurityhubInsight#threat_intel_indicator_last_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorLastObservedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt[]? ThreatIntelIndicatorLastObservedAt
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_source SecurityhubInsight#threat_intel_indicator_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorSource[]? ThreatIntelIndicatorSource
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_source_url SecurityhubInsight#threat_intel_indicator_source_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSourceUrl", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl[]? ThreatIntelIndicatorSourceUrl
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_type SecurityhubInsight#threat_intel_indicator_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorType", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorType[]? ThreatIntelIndicatorType
        {
            get;
            set;
        }

        /// <summary>threat_intel_indicator_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#threat_intel_indicator_value SecurityhubInsight#threat_intel_indicator_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorValue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersThreatIntelIndicatorValue[]? ThreatIntelIndicatorValue
        {
            get;
            set;
        }

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#title SecurityhubInsight#title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersTitle[]? Title
        {
            get;
            set;
        }

        /// <summary>type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#type SecurityhubInsight#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersType[]? Type
        {
            get;
            set;
        }

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#updated_at SecurityhubInsight#updated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updatedAt", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersUpdatedAt[]? UpdatedAt
        {
            get;
            set;
        }

        /// <summary>user_defined_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#user_defined_values SecurityhubInsight#user_defined_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userDefinedValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersUserDefinedValues[]? UserDefinedValues
        {
            get;
            set;
        }

        /// <summary>verification_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#verification_state SecurityhubInsight#verification_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationState", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersVerificationState[]? VerificationState
        {
            get;
            set;
        }

        /// <summary>workflow_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#workflow_status SecurityhubInsight#workflow_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workflowStatus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersWorkflowStatus[]? WorkflowStatus
        {
            get;
            set;
        }
    }
}
