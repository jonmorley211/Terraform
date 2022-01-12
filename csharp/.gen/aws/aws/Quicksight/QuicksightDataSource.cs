using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source aws_quicksight_data_source}.</summary>
    [JsiiClass(nativeType: typeof(aws.Quicksight.QuicksightDataSource), fullyQualifiedName: "aws.quicksight.QuicksightDataSource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceConfig\"}}]")]
    public class QuicksightDataSource : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source aws_quicksight_data_source} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public QuicksightDataSource(Constructs.Construct scope, string id, aws.Quicksight.IQuicksightDataSourceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSource(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentials\"}}]")]
        public virtual void PutCredentials(aws.Quicksight.IQuicksightDataSourceCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParameters\"}}]")]
        public virtual void PutParameters(aws.Quicksight.IQuicksightDataSourceParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSslProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceSslProperties\"}}]")]
        public virtual void PutSslProperties(aws.Quicksight.IQuicksightDataSourceSslProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceSslProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConnectionProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceVpcConnectionProperties\"}}]")]
        public virtual void PutVpcConnectionProperties(aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermission")]
        public virtual void ResetPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslProperties")]
        public virtual void ResetSslProperties()
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

        [JsiiMethod(name: "resetVpcConnectionProperties")]
        public virtual void ResetVpcConnectionProperties()
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
        = GetStaticProperty<string>(typeof(aws.Quicksight.QuicksightDataSource))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentialsOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceCredentialsOutputReference Credentials
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersOutputReference Parameters
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersOutputReference>()!;
        }

        [JsiiProperty(name: "sslProperties", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceSslPropertiesOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceSslPropertiesOutputReference SslProperties
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceSslPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConnectionProperties", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceVpcConnectionPropertiesOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceVpcConnectionPropertiesOutputReference VpcConnectionProperties
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceVpcConnectionPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceCredentials\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceCredentials? CredentialsInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParameters\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParameters? ParametersInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksight.QuicksightDataSourcePermission\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourcePermission[]? PermissionInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourcePermission[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslPropertiesInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceSslProperties\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceSslProperties? SslPropertiesInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceSslProperties?>();
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
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConnectionPropertiesInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceVpcConnectionProperties\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties? VpcConnectionPropertiesInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceVpcConnectionProperties?>();
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permission", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksight.QuicksightDataSourcePermission\"},\"kind\":\"array\"}}")]
        public virtual aws.Quicksight.IQuicksightDataSourcePermission[] Permission
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourcePermission[]>()!;
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
