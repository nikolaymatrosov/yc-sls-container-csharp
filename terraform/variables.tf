# Variables for Yandex Cloud Terraform configuration

variable "folder_id" {
  description = "Folder where to deploy the container"
  type        = string
}

variable "token" {
  description = "IAM Token to deploy the stack"
  type        = string
  sensitive   = true
}