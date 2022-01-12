using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service aws_apprunner_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apprunner.ApprunnerService), fullyQualifiedName: "aws.apprunner.ApprunnerService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceConfig\"}}]")]
    public class ApprunnerService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service aws_apprunner_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApprunnerService(Constructs.Construct scope, string id, aws.Apprunner.IApprunnerServiceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerService(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.Apprunner.IApprunnerServiceEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceHealthCheckConfiguration\"}}]")]
        public virtual void PutHealthCheckConfiguration(aws.Apprunner.IApprunnerServiceHealthCheckConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceHealthCheckConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceInstanceConfiguration\"}}]")]
        public virtual void PutInstanceConfiguration(aws.Apprunner.IApprunnerServiceInstanceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceInstanceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfiguration\"}}]")]
        public virtual void PutSourceConfiguration(aws.Apprunner.IApprunnerServiceSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apprunner.IApprunnerServiceSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingConfigurationArn")]
        public virtual void ResetAutoScalingConfigurationArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfiguration")]
        public virtual void ResetEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckConfiguration")]
        public virtual void ResetHealthCheckConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceConfiguration")]
        public virtual void ResetInstanceConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Apprunner.ApprunnerService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceEncryptionConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceHealthCheckConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceHealthCheckConfigurationOutputReference HealthCheckConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceHealthCheckConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceInstanceConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceInstanceConfigurationOutputReference InstanceConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceInstanceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationOutputReference\"}")]
        public virtual aws.Apprunner.ApprunnerServiceSourceConfigurationOutputReference SourceConfiguration
        {
            get => GetInstanceProperty<aws.Apprunner.ApprunnerServiceSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceHealthCheckConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceHealthCheckConfiguration? HealthCheckConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceHealthCheckConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceInstanceConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceInstanceConfiguration? InstanceConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceInstanceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfiguration\"}", isOptional: true)]
        public virtual aws.Apprunner.IApprunnerServiceSourceConfiguration? SourceConfigurationInput
        {
            get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfiguration?>();
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

        [JsiiProperty(name: "autoScalingConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingConfigurationArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
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
    }
}
