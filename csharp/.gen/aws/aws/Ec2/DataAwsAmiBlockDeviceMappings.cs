using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsAmiBlockDeviceMappings), fullyQualifiedName: "aws.ec2.DataAwsAmiBlockDeviceMappings", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsAmiBlockDeviceMappings : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsAmiBlockDeviceMappings(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAmiBlockDeviceMappings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAmiBlockDeviceMappings(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebs", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Ebs
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NoDevice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "virtualName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualName
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
