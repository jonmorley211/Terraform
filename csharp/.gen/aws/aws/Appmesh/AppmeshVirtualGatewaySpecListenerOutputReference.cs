using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecListenerOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecListenerOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool\"}}]")]
        public virtual void PutConnectionPool(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTls\"}}]")]
        public virtual void PutTls(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionPool")]
        public virtual void ResetConnectionPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference ConnectionPool
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerHealthCheckOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerPortMappingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerPortMappingOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPoolInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool? ConnectionPoolInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerHealthCheck\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTls\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls? TlsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListener? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
