using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontRealtimeLogConfigEndpointOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontRealtimeLogConfigEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontRealtimeLogConfigEndpointOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontRealtimeLogConfigEndpointOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontRealtimeLogConfigEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontRealtimeLogConfigEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKinesisStreamConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}}]")]
        public virtual void PutKinesisStreamConfig(aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference KinesisStreamConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpointKinesisStreamConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig? KinesisStreamConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpointKinesisStreamConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "streamType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontRealtimeLogConfigEndpoint\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpoint? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontRealtimeLogConfigEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
