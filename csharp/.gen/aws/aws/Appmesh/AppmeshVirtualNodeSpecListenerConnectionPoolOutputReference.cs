using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerConnectionPoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}}]")]
        public virtual void PutGrpc(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"}}]")]
        public virtual void PutHttp(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"}}]")]
        public virtual void PutHttp2(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"}}]")]
        public virtual void PutTcp(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTcp")]
        public virtual void ResetTcp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpcOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpcOutputReference Grpc
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpcOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttpOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttpOutputReference Http
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttpOutputReference>()!;
        }

        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2OutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2OutputReference Http2
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2OutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcpOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcpOutputReference Tcp
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolGrpc\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc? GrpcInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolGrpc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2Input", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp2\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2? Http2Input
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolHttp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp? HttpInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPoolTcp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp? TcpInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerConnectionPool\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerConnectionPool?>();
            set => SetInstanceProperty(value);
        }
    }
}
