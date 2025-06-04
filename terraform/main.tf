# Main Terraform configuration for Yandex Cloud Serverless Container

# Get the Git SHA for versioning the container image
data "external" "git_hash" {
  program = ["git", "log", "--pretty={\"sha\":\"%H\"}", "-1", "HEAD"]
}

# Service account for the container
resource "yandex_iam_service_account" "container_sa" {
  name = "container-sa"
}

# Grant the container service account permission to pull images
resource "yandex_resourcemanager_folder_iam_member" "container_image_puller" {
  folder_id = var.folder_id
  member    = "serviceAccount:${yandex_iam_service_account.container_sa.id}"
  role      = "container-registry.images.puller"

  depends_on = [yandex_iam_service_account.container_sa]
}

# Create a container registry
resource "yandex_container_registry" "cr" {
  name = "sls-demo-dotnet"
}

# Local variable for the image name
locals {
  image_name = "cr.yandex/${yandex_container_registry.cr.id}/serverless-dotnet:${data.external.git_hash.result.sha}"
}

# Build and push the Docker image
resource "null_resource" "image" {
  provisioner "local-exec" {
    command     = "docker build --platform linux/amd64  -t ${local.image_name} . && docker push ${local.image_name}"
    working_dir = "${path.module}/../ServerlessContainerDemo/"
  }

  triggers = {
    git_sha = data.external.git_hash.result.sha
  }

  depends_on = [yandex_container_registry.cr]
}

# Create the serverless container
resource "yandex_serverless_container" "container" {
  name               = "serverless-dotnet"
  memory             = 256
  service_account_id = yandex_iam_service_account.container_sa.id
  
  image {
    url = local.image_name
  }

  depends_on = [null_resource.image]
}

# Service account for invoking the container
resource "yandex_iam_service_account" "invoke_sa" {
  name = "container-invoke-sa"
}

# Grant the invoke service account permission to invoke the container
resource "yandex_resourcemanager_folder_iam_member" "container_invoker" {
  folder_id = var.folder_id
  member    = "serviceAccount:${yandex_iam_service_account.invoke_sa.id}"
  role      = "serverless-containers.containerInvoker"

  depends_on = [yandex_iam_service_account.invoke_sa]
}

# Create the API Gateway
resource "yandex_api_gateway" "apigw" {
  name = "dotnet-apigw"
  spec = templatefile("${path.module}/../ServerlessContainerDemo/swagger.yaml", {
    container_id                = yandex_serverless_container.container.id
    container_service_account_id = yandex_iam_service_account.invoke_sa.id
  })

  depends_on = [
    yandex_serverless_container.container,
    yandex_resourcemanager_folder_iam_member.container_invoker
  ]
}