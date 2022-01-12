using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appstream
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/appstream_stack aws_appstream_stack}.</summary>
    [JsiiClass(nativeType: typeof(aws.Appstream.AppstreamStack), fullyQualifiedName: "aws.appstream.AppstreamStack", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appstream.AppstreamStackConfig\"}}]")]
    public class AppstreamStack : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/appstream_stack aws_appstream_stack} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppstreamStack(Constructs.Construct scope, string id, aws.Appstream.IAppstreamStackConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppstreamStack(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppstreamStack(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appstream.AppstreamStackApplicationSettings\"}}]")]
        public virtual void PutApplicationSettings(aws.Appstream.IAppstreamStackApplicationSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appstream.IAppstreamStackApplicationSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessEndpoints")]
        public virtual void ResetAccessEndpoints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationSettings")]
        public virtual void ResetApplicationSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmbedHostDomains")]
        public virtual void ResetEmbedHostDomains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeedbackUrl")]
        public virtual void ResetFeedbackUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectUrl")]
        public virtual void ResetRedirectUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageConnectors")]
        public virtual void ResetStorageConnectors()
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

        [JsiiMethod(name: "resetUserSettings")]
        public virtual void ResetUserSettings()
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
        = GetStaticProperty<string>(typeof(aws.Appstream.AppstreamStack))!;

        [JsiiProperty(name: "applicationSettings", typeJson: "{\"fqn\":\"aws.appstream.AppstreamStackApplicationSettingsOutputReference\"}")]
        public virtual aws.Appstream.AppstreamStackApplicationSettingsOutputReference ApplicationSettings
        {
            get => GetInstanceProperty<aws.Appstream.AppstreamStackApplicationSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessEndpointsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackAccessEndpoints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appstream.IAppstreamStackAccessEndpoints[]? AccessEndpointsInput
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackAccessEndpoints[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationSettingsInput", typeJson: "{\"fqn\":\"aws.appstream.AppstreamStackApplicationSettings\"}", isOptional: true)]
        public virtual aws.Appstream.IAppstreamStackApplicationSettings? ApplicationSettingsInput
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackApplicationSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "embedHostDomainsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EmbedHostDomainsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "feedbackUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeedbackUrlInput
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
        [JsiiProperty(name: "redirectUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageConnectorsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackStorageConnectors\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appstream.IAppstreamStackStorageConnectors[]? StorageConnectorsInput
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackStorageConnectors[]?>();
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
        [JsiiProperty(name: "userSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackUserSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appstream.IAppstreamStackUserSettings[]? UserSettingsInput
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackUserSettings[]?>();
        }

        [JsiiProperty(name: "accessEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackAccessEndpoints\"},\"kind\":\"array\"}}")]
        public virtual aws.Appstream.IAppstreamStackAccessEndpoints[] AccessEndpoints
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackAccessEndpoints[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "embedHostDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EmbedHostDomains
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "feedbackUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeedbackUrl
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

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageConnectors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackStorageConnectors\"},\"kind\":\"array\"}}")]
        public virtual aws.Appstream.IAppstreamStackStorageConnectors[] StorageConnectors
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackStorageConnectors[]>()!;
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

        [JsiiProperty(name: "userSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appstream.AppstreamStackUserSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.Appstream.IAppstreamStackUserSettings[] UserSettings
        {
            get => GetInstanceProperty<aws.Appstream.IAppstreamStackUserSettings[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
