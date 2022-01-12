using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackendDefaults", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults\"}}]")]
        public virtual void PutBackendDefaults(aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults)}, new object[]{@value});
        }

        [JsiiMethod(name: "putListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}}]")]
        public virtual void PutListener(aws.Appmesh.IAppmeshVirtualNodeSpecListener @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListener)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}}]")]
        public virtual void PutLogging(aws.Appmesh.IAppmeshVirtualNodeSpecLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceDiscovery", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}}]")]
        public virtual void PutServiceDiscovery(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackend")]
        public virtual void ResetBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackendDefaults")]
        public virtual void ResetBackendDefaults()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetListener")]
        public virtual void ResetListener()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceDiscovery")]
        public virtual void ResetServiceDiscovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecBackendDefaultsOutputReference BackendDefaults
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecBackendDefaultsOutputReference>()!;
        }

        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerOutputReference Listener
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLoggingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecLoggingOutputReference Logging
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "serviceDiscovery", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryOutputReference ServiceDiscovery
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendDefaultsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults? BackendDefaultsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]? BackendInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListener? ListenerInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListener?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecLogging\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecLogging? LoggingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceDiscoveryInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery? ServiceDiscoveryInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery?>();
        }

        [JsiiProperty(name: "backend", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackend\"},\"kind\":\"array\"}}")]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackend[] Backend
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackend[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
