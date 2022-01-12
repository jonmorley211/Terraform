using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicecatalog
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/servicecatalog_service_action aws_servicecatalog_service_action}.</summary>
    [JsiiClass(nativeType: typeof(aws.Servicecatalog.ServicecatalogServiceAction), fullyQualifiedName: "aws.servicecatalog.ServicecatalogServiceAction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.servicecatalog.ServicecatalogServiceActionConfig\"}}]")]
    public class ServicecatalogServiceAction : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/servicecatalog_service_action aws_servicecatalog_service_action} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServicecatalogServiceAction(Constructs.Construct scope, string id, aws.Servicecatalog.IServicecatalogServiceActionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicecatalogServiceAction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicecatalogServiceAction(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicecatalog.ServicecatalogServiceActionDefinition\"}}]")]
        public virtual void PutDefinition(aws.Servicecatalog.IServicecatalogServiceActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicecatalog.IServicecatalogServiceActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptLanguage")]
        public virtual void ResetAcceptLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
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
        = GetStaticProperty<string>(typeof(aws.Servicecatalog.ServicecatalogServiceAction))!;

        [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogServiceActionDefinitionOutputReference\"}")]
        public virtual aws.Servicecatalog.ServicecatalogServiceActionDefinitionOutputReference Definition
        {
            get => GetInstanceProperty<aws.Servicecatalog.ServicecatalogServiceActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceptLanguageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcceptLanguageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definitionInput", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogServiceActionDefinition\"}", isOptional: true)]
        public virtual aws.Servicecatalog.IServicecatalogServiceActionDefinition? DefinitionInput
        {
            get => GetInstanceProperty<aws.Servicecatalog.IServicecatalogServiceActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acceptLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptLanguage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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
    }
}
