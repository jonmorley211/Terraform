using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackendDefaults", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults\"}}]")]
        public virtual void PutBackendDefaults(aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults)}, new object[]{@value});
        }

        [JsiiMethod(name: "putListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListener\"}}]")]
        public virtual void PutListener(aws.Appmesh.IAppmeshVirtualGatewaySpecListener @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListener)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLogging\"}}]")]
        public virtual void PutLogging(aws.Appmesh.IAppmeshVirtualGatewaySpecLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackendDefaults")]
        public virtual void ResetBackendDefaults()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backendDefaults", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference BackendDefaults
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference>()!;
        }

        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerOutputReference Listener
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecLoggingOutputReference Logging
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecLoggingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendDefaultsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults? BackendDefaultsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListener? ListenerInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListener?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecLogging? LoggingInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
