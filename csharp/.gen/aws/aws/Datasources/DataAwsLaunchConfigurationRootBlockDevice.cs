using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    [JsiiClass(nativeType: typeof(aws.Datasources.DataAwsLaunchConfigurationRootBlockDevice), fullyQualifiedName: "aws.datasources.DataAwsLaunchConfigurationRootBlockDevice", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsLaunchConfigurationRootBlockDevice : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsLaunchConfigurationRootBlockDevice(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfigurationRootBlockDevice(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfigurationRootBlockDevice(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object DeleteOnTermination
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Encrypted
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Iops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Throughput
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
