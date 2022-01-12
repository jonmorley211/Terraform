using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPool", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool\"}}]")]
        public virtual void PutConnectionPool(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutlierDetection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection\"}}]")]
        public virtual void PutOutlierDetection(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}}]")]
        public virtual void PutPortMapping(aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout\"}}]")]
        public virtual void PutTimeout(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTls\"}}]")]
        public virtual void PutTls(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls)}, new object[]{@value});
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

        [JsiiMethod(name: "resetOutlierDetection")]
        public virtual void ResetOutlierDetection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionPool", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference ConnectionPool
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "outlierDetection", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference OutlierDetection
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionOutputReference>()!;
        }

        [JsiiProperty(name: "portMapping", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference PortMapping
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerPortMappingOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPoolInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool? ConnectionPoolInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerHealthCheck\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outlierDetectionInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection? OutlierDetectionInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portMappingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerPortMapping\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping? PortMappingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerPortMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTls\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls? TlsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListener? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
