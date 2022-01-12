using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicecatalog
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/servicecatalog_provisioned_product aws_servicecatalog_provisioned_product}.</summary>
    [JsiiClass(nativeType: typeof(aws.Servicecatalog.ServicecatalogProvisionedProduct), fullyQualifiedName: "aws.servicecatalog.ServicecatalogProvisionedProduct", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductConfig\"}}]")]
    public class ServicecatalogProvisionedProduct : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/servicecatalog_provisioned_product aws_servicecatalog_provisioned_product} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServicecatalogProvisionedProduct(Constructs.Construct scope, string id, aws.Servicecatalog.IServicecatalogProvisionedProductConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicecatalogProvisionedProduct(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicecatalogProvisionedProduct(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStackSetProvisioningPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductStackSetProvisioningPreferences\"}}]")]
        public virtual void PutStackSetProvisioningPreferences(aws.Servicecatalog.IServicecatalogProvisionedProductStackSetProvisioningPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicecatalog.IServicecatalogProvisionedProductStackSetProvisioningPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Servicecatalog.IServicecatalogProvisionedProductTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Servicecatalog.IServicecatalogProvisionedProductTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptLanguage")]
        public virtual void ResetAcceptLanguage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreErrors")]
        public virtual void ResetIgnoreErrors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationArns")]
        public virtual void ResetNotificationArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathId")]
        public virtual void ResetPathId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathName")]
        public virtual void ResetPathName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductId")]
        public virtual void ResetProductId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductName")]
        public virtual void ResetProductName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisioningArtifactId")]
        public virtual void ResetProvisioningArtifactId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisioningArtifactName")]
        public virtual void ResetProvisioningArtifactName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisioningParameters")]
        public virtual void ResetProvisioningParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainPhysicalResources")]
        public virtual void ResetRetainPhysicalResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStackSetProvisioningPreferences")]
        public virtual void ResetStackSetProvisioningPreferences()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Servicecatalog.ServicecatalogProvisionedProduct))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudwatchDashboardNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CloudwatchDashboardNames
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "lastProvisioningRecordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastProvisioningRecordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastRecordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastRecordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastSuccessfulProvisioningRecordId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSuccessfulProvisioningRecordId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackSetProvisioningPreferences", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductStackSetProvisioningPreferencesOutputReference\"}")]
        public virtual aws.Servicecatalog.ServicecatalogProvisionedProductStackSetProvisioningPreferencesOutputReference StackSetProvisioningPreferences
        {
            get => GetInstanceProperty<aws.Servicecatalog.ServicecatalogProvisionedProductStackSetProvisioningPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductTimeoutsOutputReference\"}")]
        public virtual aws.Servicecatalog.ServicecatalogProvisionedProductTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Servicecatalog.ServicecatalogProvisionedProductTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
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
        [JsiiProperty(name: "ignoreErrorsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IgnoreErrorsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NotificationArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisioningArtifactIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvisioningArtifactIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisioningArtifactNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvisioningArtifactNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisioningParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductProvisioningParameters\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Servicecatalog.IServicecatalogProvisionedProductProvisioningParameters[]? ProvisioningParametersInput
        {
            get => GetInstanceProperty<aws.Servicecatalog.IServicecatalogProvisionedProductProvisioningParameters[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainPhysicalResourcesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RetainPhysicalResourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackSetProvisioningPreferencesInput", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductStackSetProvisioningPreferences\"}", isOptional: true)]
        public virtual aws.Servicecatalog.IServicecatalogProvisionedProductStackSetProvisioningPreferences? StackSetProvisioningPreferencesInput
        {
            get => GetInstanceProperty<aws.Servicecatalog.IServicecatalogProvisionedProductStackSetProvisioningPreferences?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductTimeouts\"}", isOptional: true)]
        public virtual aws.Servicecatalog.IServicecatalogProvisionedProductTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Servicecatalog.IServicecatalogProvisionedProductTimeouts?>();
        }

        [JsiiProperty(name: "acceptLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptLanguage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreErrors", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IgnoreErrors
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

        [JsiiProperty(name: "notificationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NotificationArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pathName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisioningArtifactId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningArtifactId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisioningArtifactName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningArtifactName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisioningParameters", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.servicecatalog.ServicecatalogProvisionedProductProvisioningParameters\"},\"kind\":\"array\"}}")]
        public virtual aws.Servicecatalog.IServicecatalogProvisionedProductProvisioningParameters[] ProvisioningParameters
        {
            get => GetInstanceProperty<aws.Servicecatalog.IServicecatalogProvisionedProductProvisioningParameters[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainPhysicalResources", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RetainPhysicalResources
        {
            get => GetInstanceProperty<object>()!;
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
