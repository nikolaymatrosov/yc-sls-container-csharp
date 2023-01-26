using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiByValue(fqn: "yandex.storageBucket.StorageBucketWebsite")]
    public class StorageBucketWebsite : yandex.StorageBucket.IStorageBucketWebsite
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#error_document StorageBucket#error_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorDocument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#index_document StorageBucket#index_document}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexDocument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#redirect_all_requests_to StorageBucket#redirect_all_requests_to}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectAllRequestsTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#routing_rules StorageBucket#routing_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingRules
        {
            get;
            set;
        }
    }
}
