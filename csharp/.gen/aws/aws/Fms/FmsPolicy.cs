using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fms
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/fms_policy aws_fms_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Fms.FmsPolicy), fullyQualifiedName: "aws.fms.FmsPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.fms.FmsPolicyConfig\"}}]")]
    public class FmsPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/fms_policy aws_fms_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FmsPolicy(Constructs.Construct scope, string id, aws.Fms.IFmsPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FmsPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FmsPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExcludeMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fms.FmsPolicyExcludeMap\"}}]")]
        public virtual void PutExcludeMap(aws.Fms.IFmsPolicyExcludeMap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fms.IFmsPolicyExcludeMap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIncludeMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fms.FmsPolicyIncludeMap\"}}]")]
        public virtual void PutIncludeMap(aws.Fms.IFmsPolicyIncludeMap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fms.IFmsPolicyIncludeMap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityServicePolicyData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fms.FmsPolicySecurityServicePolicyData\"}}]")]
        public virtual void PutSecurityServicePolicyData(aws.Fms.IFmsPolicySecurityServicePolicyData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fms.IFmsPolicySecurityServicePolicyData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeleteAllPolicyResources")]
        public virtual void ResetDeleteAllPolicyResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeMap")]
        public virtual void ResetExcludeMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeMap")]
        public virtual void ResetIncludeMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemediationEnabled")]
        public virtual void ResetRemediationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTags")]
        public virtual void ResetResourceTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeList")]
        public virtual void ResetResourceTypeList()
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
        = GetStaticProperty<string>(typeof(aws.Fms.FmsPolicy))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "excludeMap", typeJson: "{\"fqn\":\"aws.fms.FmsPolicyExcludeMapOutputReference\"}")]
        public virtual aws.Fms.FmsPolicyExcludeMapOutputReference ExcludeMap
        {
            get => GetInstanceProperty<aws.Fms.FmsPolicyExcludeMapOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "includeMap", typeJson: "{\"fqn\":\"aws.fms.FmsPolicyIncludeMapOutputReference\"}")]
        public virtual aws.Fms.FmsPolicyIncludeMapOutputReference IncludeMap
        {
            get => GetInstanceProperty<aws.Fms.FmsPolicyIncludeMapOutputReference>()!;
        }

        [JsiiProperty(name: "policyUpdateToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyUpdateToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityServicePolicyData", typeJson: "{\"fqn\":\"aws.fms.FmsPolicySecurityServicePolicyDataOutputReference\"}")]
        public virtual aws.Fms.FmsPolicySecurityServicePolicyDataOutputReference SecurityServicePolicyData
        {
            get => GetInstanceProperty<aws.Fms.FmsPolicySecurityServicePolicyDataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteAllPolicyResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteAllPolicyResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeMapInput", typeJson: "{\"fqn\":\"aws.fms.FmsPolicyExcludeMap\"}", isOptional: true)]
        public virtual aws.Fms.IFmsPolicyExcludeMap? ExcludeMapInput
        {
            get => GetInstanceProperty<aws.Fms.IFmsPolicyExcludeMap?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeResourceTagsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExcludeResourceTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeMapInput", typeJson: "{\"fqn\":\"aws.fms.FmsPolicyIncludeMap\"}", isOptional: true)]
        public virtual aws.Fms.IFmsPolicyIncludeMap? IncludeMapInput
        {
            get => GetInstanceProperty<aws.Fms.IFmsPolicyIncludeMap?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remediationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RemediationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? ResourceTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeListInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ResourceTypeListInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityServicePolicyDataInput", typeJson: "{\"fqn\":\"aws.fms.FmsPolicySecurityServicePolicyData\"}", isOptional: true)]
        public virtual aws.Fms.IFmsPolicySecurityServicePolicyData? SecurityServicePolicyDataInput
        {
            get => GetInstanceProperty<aws.Fms.IFmsPolicySecurityServicePolicyData?>();
        }

        [JsiiProperty(name: "deleteAllPolicyResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteAllPolicyResources
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludeResourceTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ExcludeResourceTags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remediationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RemediationEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object ResourceTags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResourceTypeList
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
