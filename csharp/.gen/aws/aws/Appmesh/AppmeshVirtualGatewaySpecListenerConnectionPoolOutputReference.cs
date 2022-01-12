using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerConnectionPoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}}]")]
        public virtual void PutGrpc(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}}]")]
        public virtual void PutHttp(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}}]")]
        public virtual void PutHttp2(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpc")]
        public virtual void ResetGrpc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp")]
        public virtual void ResetHttp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp2")]
        public virtual void ResetHttp2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference Grpc
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpcOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference Http
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttpOutputReference>()!;
        }

        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference Http2
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc? GrpcInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolGrpc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2Input", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2? Http2Input
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPoolHttp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp? HttpInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPoolHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerConnectionPool?>();
            set => SetInstanceProperty(value);
        }
    }
}
