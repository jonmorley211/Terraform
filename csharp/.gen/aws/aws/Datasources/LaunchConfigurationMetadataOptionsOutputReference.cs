using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    [JsiiClass(nativeType: typeof(aws.Datasources.LaunchConfigurationMetadataOptionsOutputReference), fullyQualifiedName: "aws.datasources.LaunchConfigurationMetadataOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LaunchConfigurationMetadataOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LaunchConfigurationMetadataOptionsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchConfigurationMetadataOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchConfigurationMetadataOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHttpEndpoint")]
        public virtual void ResetHttpEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpPutResponseHopLimit")]
        public virtual void ResetHttpPutResponseHopLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpTokens")]
        public virtual void ResetHttpTokens()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPutResponseHopLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPutResponseHopLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTokensInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpTokensInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "httpEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpPutResponseHopLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPutResponseHopLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpTokens", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpTokens
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.datasources.LaunchConfigurationMetadataOptions\"}", isOptional: true)]
        public virtual aws.Datasources.ILaunchConfigurationMetadataOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Datasources.ILaunchConfigurationMetadataOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
