using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway aws_storagegateway_gateway}.</summary>
    [JsiiClass(nativeType: typeof(aws.Storagegateway.StoragegatewayGateway), fullyQualifiedName: "aws.storagegateway.StoragegatewayGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayConfig\"}}]")]
    public class StoragegatewayGateway : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway aws_storagegateway_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StoragegatewayGateway(Constructs.Construct scope, string id, aws.Storagegateway.IStoragegatewayGatewayConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGateway(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "gatewayNetworkInterface", returnsJson: "{\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayGatewayNetworkInterface\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Storagegateway.StoragegatewayGatewayGatewayNetworkInterface GatewayNetworkInterface(string index)
        {
            return InvokeInstanceMethod<aws.Storagegateway.StoragegatewayGatewayGatewayNetworkInterface>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "putSmbActiveDirectorySettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}}]")]
        public virtual void PutSmbActiveDirectorySettings(aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Storagegateway.IStoragegatewayGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Storagegateway.IStoragegatewayGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActivationKey")]
        public virtual void ResetActivationKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAverageDownloadRateLimitInBitsPerSec")]
        public virtual void ResetAverageDownloadRateLimitInBitsPerSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAverageUploadRateLimitInBitsPerSec")]
        public virtual void ResetAverageUploadRateLimitInBitsPerSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchLogGroupArn")]
        public virtual void ResetCloudwatchLogGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayIpAddress")]
        public virtual void ResetGatewayIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayType")]
        public virtual void ResetGatewayType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGatewayVpcEndpoint")]
        public virtual void ResetGatewayVpcEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMediumChangerType")]
        public virtual void ResetMediumChangerType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbActiveDirectorySettings")]
        public virtual void ResetSmbActiveDirectorySettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbFileShareVisibility")]
        public virtual void ResetSmbFileShareVisibility()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbGuestPassword")]
        public virtual void ResetSmbGuestPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmbSecurityStrategy")]
        public virtual void ResetSmbSecurityStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTapeDriveType")]
        public virtual void ResetTapeDriveType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Storagegateway.StoragegatewayGateway))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ec2InstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ec2InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostEnvironment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostEnvironment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference\"}")]
        public virtual aws.Storagegateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference SmbActiveDirectorySettings
        {
            get => GetInstanceProperty<aws.Storagegateway.StoragegatewayGatewaySmbActiveDirectorySettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeoutsOutputReference\"}")]
        public virtual aws.Storagegateway.StoragegatewayGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Storagegateway.StoragegatewayGatewayTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activationKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActivationKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "averageDownloadRateLimitInBitsPerSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AverageDownloadRateLimitInBitsPerSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "averageUploadRateLimitInBitsPerSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AverageUploadRateLimitInBitsPerSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayIpAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayIpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayTimezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayTimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gatewayVpcEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GatewayVpcEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediumChangerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediumChangerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbActiveDirectorySettingsInput", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings? SmbActiveDirectorySettingsInput
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbFileShareVisibilityInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmbFileShareVisibilityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbGuestPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmbGuestPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smbSecurityStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmbSecurityStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tapeDriveTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TapeDriveTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
        public virtual aws.Storagegateway.IStoragegatewayGatewayTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayGatewayTimeouts?>();
        }

        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActivationKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "averageDownloadRateLimitInBitsPerSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AverageDownloadRateLimitInBitsPerSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "averageUploadRateLimitInBitsPerSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AverageUploadRateLimitInBitsPerSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayIpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayTimezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GatewayVpcEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MediumChangerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbFileShareVisibility", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SmbFileShareVisibility
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmbGuestPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smbSecurityStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmbSecurityStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TapeDriveType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
