using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Serverlessapplicationrepository
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/serverlessapplicationrepository_application aws_serverlessapplicationrepository_application}.</summary>
    [JsiiClass(nativeType: typeof(aws.Serverlessapplicationrepository.DataAwsServerlessapplicationrepositoryApplication), fullyQualifiedName: "aws.serverlessapplicationrepository.DataAwsServerlessapplicationrepositoryApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.serverlessapplicationrepository.DataAwsServerlessapplicationrepositoryApplicationConfig\"}}]")]
    public class DataAwsServerlessapplicationrepositoryApplication : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/serverlessapplicationrepository_application aws_serverlessapplicationrepository_application} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsServerlessapplicationrepositoryApplication(Constructs.Construct scope, string id, aws.Serverlessapplicationrepository.IDataAwsServerlessapplicationrepositoryApplicationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServerlessapplicationrepositoryApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServerlessapplicationrepositoryApplication(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSemanticVersion")]
        public virtual void ResetSemanticVersion()
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
        = GetStaticProperty<string>(typeof(aws.Serverlessapplicationrepository.DataAwsServerlessapplicationrepositoryApplication))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requiredCapabilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequiredCapabilities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sourceCodeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCodeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "templateUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "semanticVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SemanticVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "semanticVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SemanticVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
