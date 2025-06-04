# Terraform Configuration for Yandex Cloud Serverless Container

This directory contains Terraform configuration files for deploying a .NET 6 Web API application to Yandex Cloud Serverless Container.

## Prerequisites

- [Terraform](https://www.terraform.io/downloads.html) (version >= 1.0.0)
- [Docker](https://docs.docker.com/get-docker/)
- [Yandex Cloud CLI](https://cloud.yandex.com/en/docs/cli/quickstart)
- Git

## Files

- `variables.tf` - Input variables for the configuration
- `providers.tf` - Provider configurations
- `main.tf` - Main resource definitions
- `outputs.tf` - Output values

## Usage

1. Initialize Terraform:

```bash
terraform init
```

2. Set the required variables:

```bash
export TF_VAR_folder_id=b1g***
export TF_VAR_token=$(yc iam create-token)
```

3. Plan the deployment:

```bash
terraform plan
```

4. Apply the configuration:

```bash
terraform apply
```

5. After the deployment is complete, the outputs will show:
   - `container_url` - The URL of the serverless container
   - `apigw_url` - The URL of the API Gateway

## Resources Created

- Service accounts for the container and API Gateway
- IAM permissions
- Container Registry
- Serverless Container with the application
- API Gateway to expose the container

## Notes

- The Docker image is built and pushed automatically during the Terraform apply
- The image is tagged with the Git SHA of the latest commit
- The API Gateway is configured using the swagger.yaml file from the application