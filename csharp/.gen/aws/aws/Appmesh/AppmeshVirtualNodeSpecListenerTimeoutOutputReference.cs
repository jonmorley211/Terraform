using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc\"}}]")]
        public virtual void PutGrpc(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp\"}}]")]
        public virtual void PutHttp(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2\"}}]")]
        public virtual void PutHttp2(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp\"}}]")]
        public virtual void PutTcp(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp)}, new object[]{@value});
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

        [JsiiProperty(name: "grpc", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference Grpc
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference>()!;
        }

        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference Http
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference>()!;
        }

        [JsiiProperty(name: "http2", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference Http2
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference>()!;
        }

        [JsiiProperty(name: "tcp", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference Tcp
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutGrpc\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc? GrpcInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutGrpc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2Input", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2? Http2Input
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp? HttpInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutTcp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp? TcpInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutTcp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
