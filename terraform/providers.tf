# Provider configuration for Terraform

terraform {
  required_providers {
    yandex = {
      source  = "yandex-cloud/yandex"
      version = "~> 0.84.0"
    }
    null = {
      source  = "hashicorp/null"
      version = "~> 3.2.0"
    }
    external = {
      source  = "hashicorp/external"
      version = "~> 2.3.0"
    }
  }
  required_version = ">= 1.0.0"
}

provider "yandex" {
  folder_id = var.folder_id
  token     = var.token
}

provider "null" {}

provider "external" {}