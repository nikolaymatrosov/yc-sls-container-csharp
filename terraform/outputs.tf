# Output values for the Terraform configuration

output "container_url" {
  description = "URL of the serverless container"
  value       = yandex_serverless_container.container.url
}

output "apigw_url" {
  description = "URL of the API Gateway"
  value       = yandex_api_gateway.apigw.domain
}