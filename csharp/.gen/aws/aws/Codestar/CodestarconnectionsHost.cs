using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codestar
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/codestarconnections_host aws_codestarconnections_host}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codestar.CodestarconnectionsHost), fullyQualifiedName: "aws.codestar.CodestarconnectionsHost", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codestar.CodestarconnectionsHostConfig\"}}]")]
    public class CodestarconnectionsHost : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/codestarconnections_host aws_codestarconnections_host} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodestarconnectionsHost(Constructs.Construct scope, string id, aws.Codestar.ICodestarconnectionsHostConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodestarconnectionsHost(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodestarconnectionsHost(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVpcConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codestar.CodestarconnectionsHostVpcConfiguration\"}}]")]
        public virtual void PutVpcConfiguration(aws.Codestar.ICodestarconnectionsHostVpcConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codestar.ICodestarconnectionsHostVpcConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetVpcConfiguration")]
        public virtual void ResetVpcConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Codestar.CodestarconnectionsHost))!;

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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.codestar.CodestarconnectionsHostVpcConfigurationOutputReference\"}")]
        public virtual aws.Codestar.CodestarconnectionsHostVpcConfigurationOutputReference VpcConfiguration
        {
            get => GetInstanceProperty<aws.Codestar.CodestarconnectionsHostVpcConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProviderEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "providerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProviderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigurationInput", typeJson: "{\"fqn\":\"aws.codestar.CodestarconnectionsHostVpcConfiguration\"}", isOptional: true)]
        public virtual aws.Codestar.ICodestarconnectionsHostVpcConfiguration? VpcConfigurationInput
        {
            get => GetInstanceProperty<aws.Codestar.ICodestarconnectionsHostVpcConfiguration?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "providerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "providerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProviderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
