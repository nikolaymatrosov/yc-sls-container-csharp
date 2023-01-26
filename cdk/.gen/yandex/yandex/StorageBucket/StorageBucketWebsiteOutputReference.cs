using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiClass(nativeType: typeof(yandex.StorageBucket.StorageBucketWebsiteOutputReference), fullyQualifiedName: "yandex.storageBucket.StorageBucketWebsiteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageBucketWebsiteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageBucketWebsiteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucketWebsiteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucketWebsiteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetErrorDocument")]
        public virtual void ResetErrorDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexDocument")]
        public virtual void ResetIndexDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectAllRequestsTo")]
        public virtual void ResetRedirectAllRequestsTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingRules")]
        public virtual void ResetRoutingRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectAllRequestsToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingRulesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingRulesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectAllRequestsTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingRules
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketWebsite\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketWebsite? InternalValue
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketWebsite?>();
            set => SetInstanceProperty(value);
        }
    }
}
