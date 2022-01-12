using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourcegroups
{
    [JsiiClass(nativeType: typeof(aws.Resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails), fullyQualifiedName: "aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResourcesResourceTagMappingListComplianceDetails(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "complianceStatus", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ComplianceStatus
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "keysWithNoncompliantValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] KeysWithNoncompliantValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nonCompliantKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NonCompliantKeys
        {
            get => GetInstanceProperty<string[]>()!;
        }
    }
}
