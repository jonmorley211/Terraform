using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiClass(nativeType: typeof(aws.Athena.AthenaWorkgroupConfigurationOutputReference), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AthenaWorkgroupConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AthenaWorkgroupConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEngineVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationEngineVersion\"}}]")]
        public virtual void PutEngineVersion(aws.Athena.IAthenaWorkgroupConfigurationEngineVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Athena.IAthenaWorkgroupConfigurationEngineVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResultConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}}]")]
        public virtual void PutResultConfiguration(aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBytesScannedCutoffPerQuery")]
        public virtual void ResetBytesScannedCutoffPerQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnforceWorkgroupConfiguration")]
        public virtual void ResetEnforceWorkgroupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngineVersion")]
        public virtual void ResetEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublishCloudwatchMetricsEnabled")]
        public virtual void ResetPublishCloudwatchMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequesterPaysEnabled")]
        public virtual void ResetRequesterPaysEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResultConfiguration")]
        public virtual void ResetResultConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationEngineVersionOutputReference\"}")]
        public virtual aws.Athena.AthenaWorkgroupConfigurationEngineVersionOutputReference EngineVersion
        {
            get => GetInstanceProperty<aws.Athena.AthenaWorkgroupConfigurationEngineVersionOutputReference>()!;
        }

        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference\"}")]
        public virtual aws.Athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference ResultConfiguration
        {
            get => GetInstanceProperty<aws.Athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQueryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BytesScannedCutoffPerQueryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceWorkgroupConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationEngineVersion? EngineVersionInput
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationEngineVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublishCloudwatchMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterPaysEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequesterPaysEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resultConfigurationInput", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfigurationInput
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration?>();
        }

        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BytesScannedCutoffPerQuery
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnforceWorkgroupConfiguration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublishCloudwatchMetricsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requesterPaysEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequesterPaysEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
