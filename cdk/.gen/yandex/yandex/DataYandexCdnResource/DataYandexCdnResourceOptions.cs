using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexCdnResource
{
    [JsiiByValue(fqn: "yandex.dataYandexCdnResource.DataYandexCdnResourceOptions")]
    public class DataYandexCdnResourceOptions : yandex.DataYandexCdnResource.IDataYandexCdnResourceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#allowed_http_methods DataYandexCdnResource#allowed_http_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedHttpMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#browser_cache_settings DataYandexCdnResource#browser_cache_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "browserCacheSettings", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BrowserCacheSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#cache_http_headers DataYandexCdnResource#cache_http_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheHttpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CacheHttpHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#cors DataYandexCdnResource#cors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Cors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#custom_host_header DataYandexCdnResource#custom_host_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customHostHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomHostHeader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#custom_server_name DataYandexCdnResource#custom_server_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customServerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomServerName
        {
            get;
            set;
        }

        private object? _disableCache;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#disable_cache DataYandexCdnResource#disable_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableCache
        {
            get => _disableCache;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disableCache = value;
            }
        }

        private object? _disableProxyForceRanges;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#disable_proxy_force_ranges DataYandexCdnResource#disable_proxy_force_ranges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableProxyForceRanges", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableProxyForceRanges
        {
            get => _disableProxyForceRanges;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _disableProxyForceRanges = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#edge_cache_settings DataYandexCdnResource#edge_cache_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeCacheSettings", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EdgeCacheSettings
        {
            get;
            set;
        }

        private object? _fetchedCompressed;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#fetched_compressed DataYandexCdnResource#fetched_compressed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fetchedCompressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FetchedCompressed
        {
            get => _fetchedCompressed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fetchedCompressed = value;
            }
        }

        private object? _forwardHostHeader;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#forward_host_header DataYandexCdnResource#forward_host_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forwardHostHeader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForwardHostHeader
        {
            get => _forwardHostHeader;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forwardHostHeader = value;
            }
        }

        private object? _gzipOn;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#gzip_on DataYandexCdnResource#gzip_on}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gzipOn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? GzipOn
        {
            get => _gzipOn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _gzipOn = value;
            }
        }

        private object? _ignoreCookie;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#ignore_cookie DataYandexCdnResource#ignore_cookie}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreCookie", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreCookie
        {
            get => _ignoreCookie;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreCookie = value;
            }
        }

        private object? _ignoreQueryParams;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#ignore_query_params DataYandexCdnResource#ignore_query_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreQueryParams", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreQueryParams
        {
            get => _ignoreQueryParams;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreQueryParams = value;
            }
        }

        private object? _proxyCacheMethodsSet;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#proxy_cache_methods_set DataYandexCdnResource#proxy_cache_methods_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proxyCacheMethodsSet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ProxyCacheMethodsSet
        {
            get => _proxyCacheMethodsSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _proxyCacheMethodsSet = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#query_params_blacklist DataYandexCdnResource#query_params_blacklist}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryParamsBlacklist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QueryParamsBlacklist
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#query_params_whitelist DataYandexCdnResource#query_params_whitelist}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryParamsWhitelist", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? QueryParamsWhitelist
        {
            get;
            set;
        }

        private object? _redirectHttpsToHttp;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#redirect_https_to_http DataYandexCdnResource#redirect_https_to_http}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectHttpsToHttp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RedirectHttpsToHttp
        {
            get => _redirectHttpsToHttp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirectHttpsToHttp = value;
            }
        }

        private object? _redirectHttpToHttps;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#redirect_http_to_https DataYandexCdnResource#redirect_http_to_https}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectHttpToHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RedirectHttpToHttps
        {
            get => _redirectHttpToHttps;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirectHttpToHttps = value;
            }
        }

        private object? _slice;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#slice DataYandexCdnResource#slice}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Slice
        {
            get => _slice;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slice = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#static_request_headers DataYandexCdnResource#static_request_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticRequestHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? StaticRequestHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#static_response_headers DataYandexCdnResource#static_response_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "staticResponseHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StaticResponseHeaders
        {
            get;
            set;
        }
    }
}
