using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group aws_sagemaker_feature_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFeatureGroup), fullyQualifiedName: "aws.sagemaker.SagemakerFeatureGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupConfig\"}}]")]
    public class SagemakerFeatureGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_feature_group aws_sagemaker_feature_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerFeatureGroup(Constructs.Construct scope, string id, aws.Sagemaker.ISagemakerFeatureGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFeatureGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOfflineStoreConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig\"}}]")]
        public virtual void PutOfflineStoreConfig(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnlineStoreConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig\"}}]")]
        public virtual void PutOnlineStoreConfig(aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOfflineStoreConfig")]
        public virtual void ResetOfflineStoreConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnlineStoreConfig")]
        public virtual void ResetOnlineStoreConfig()
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
        = GetStaticProperty<string>(typeof(aws.Sagemaker.SagemakerFeatureGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "offlineStoreConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigOutputReference OfflineStoreConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFeatureGroupOfflineStoreConfigOutputReference>()!;
        }

        [JsiiProperty(name: "onlineStoreConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFeatureGroupOnlineStoreConfigOutputReference OnlineStoreConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFeatureGroupOnlineStoreConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTimeFeatureNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventTimeFeatureNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureDefinitionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupFeatureDefinition\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition[]? FeatureDefinitionInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "offlineStoreConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOfflineStoreConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig? OfflineStoreConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOfflineStoreConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onlineStoreConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupOnlineStoreConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig? OnlineStoreConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupOnlineStoreConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordIdentifierFeatureNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordIdentifierFeatureNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventTimeFeatureName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventTimeFeatureName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featureDefinition", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerFeatureGroupFeatureDefinition\"},\"kind\":\"array\"}}")]
        public virtual aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition[] FeatureDefinition
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFeatureGroupFeatureDefinition[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featureGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordIdentifierFeatureName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordIdentifierFeatureName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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
