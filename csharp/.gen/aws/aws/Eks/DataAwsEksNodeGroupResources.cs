using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.DataAwsEksNodeGroupResources), fullyQualifiedName: "aws.eks.DataAwsEksNodeGroupResources", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsEksNodeGroupResources : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsEksNodeGroupResources(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEksNodeGroupResources(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEksNodeGroupResources(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoscalingGroups", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AutoscalingGroups
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "remoteAccessSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteAccessSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
