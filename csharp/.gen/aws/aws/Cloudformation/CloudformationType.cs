using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type aws_cloudformation_type}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudformation.CloudformationType), fullyQualifiedName: "aws.cloudformation.CloudformationType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudformation.CloudformationTypeConfig\"}}]")]
    public class CloudformationType : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type aws_cloudformation_type} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudformationType(Constructs.Construct scope, string id, aws.Cloudformation.ICloudformationTypeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationType(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformation.CloudformationTypeLoggingConfig\"}}]")]
        public virtual void PutLoggingConfig(aws.Cloudformation.ICloudformationTypeLoggingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudformation.ICloudformationTypeLoggingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExecutionRoleArn")]
        public virtual void ResetExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfig")]
        public virtual void ResetLoggingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(aws.Cloudformation.CloudformationType))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultVersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deprecatedStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeprecatedStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefaultVersion", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object IsDefaultVersion
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.cloudformation.CloudformationTypeLoggingConfigOutputReference\"}")]
        public virtual aws.Cloudformation.CloudformationTypeLoggingConfigOutputReference LoggingConfig
        {
            get => GetInstanceProperty<aws.Cloudformation.CloudformationTypeLoggingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "provisioningType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schema
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "typeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Visibility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigInput", typeJson: "{\"fqn\":\"aws.cloudformation.CloudformationTypeLoggingConfig\"}", isOptional: true)]
        public virtual aws.Cloudformation.ICloudformationTypeLoggingConfig? LoggingConfigInput
        {
            get => GetInstanceProperty<aws.Cloudformation.ICloudformationTypeLoggingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaHandlerPackageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchemaHandlerPackageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemaHandlerPackage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchemaHandlerPackage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "typeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TypeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
