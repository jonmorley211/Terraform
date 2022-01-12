using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiClass(nativeType: typeof(aws.Globalaccelerator.DataAwsGlobalacceleratorAcceleratorAttributes), fullyQualifiedName: "aws.globalaccelerator.DataAwsGlobalacceleratorAcceleratorAttributes", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsGlobalacceleratorAcceleratorAttributes : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsGlobalacceleratorAcceleratorAttributes(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlobalacceleratorAcceleratorAttributes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsGlobalacceleratorAcceleratorAttributes(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object FlowLogsEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogsS3Bucket
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlowLogsS3Prefix
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
