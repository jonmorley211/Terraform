using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resourcegroups
{
    [JsiiClass(nativeType: typeof(aws.Resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList), fullyQualifiedName: "aws.resourcegroups.DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourcegroupstaggingapiResourcesResourceTagMappingList(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "complianceDetails", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ComplianceDetails
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "resourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
