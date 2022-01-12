using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/api_gateway_domain_name aws_api_gateway_domain_name}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigateway.DataAwsApiGatewayDomainName), fullyQualifiedName: "aws.apigateway.DataAwsApiGatewayDomainName", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigateway.DataAwsApiGatewayDomainNameConfig\"}}]")]
    public class DataAwsApiGatewayDomainName : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/api_gateway_domain_name aws_api_gateway_domain_name} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsApiGatewayDomainName(Constructs.Construct scope, string id, aws.Apigateway.IDataAwsApiGatewayDomainNameConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsApiGatewayDomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsApiGatewayDomainName(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "endpointConfiguration", returnsJson: "{\"type\":{\"fqn\":\"aws.apigateway.DataAwsApiGatewayDomainNameEndpointConfiguration\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Apigateway.DataAwsApiGatewayDomainNameEndpointConfiguration EndpointConfiguration(string index)
        {
            return InvokeInstanceMethod<aws.Apigateway.DataAwsApiGatewayDomainNameEndpointConfiguration>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Apigateway.DataAwsApiGatewayDomainName))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateUploadDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateUploadDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalCertificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
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
    }
}
