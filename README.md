Это репозиторий с примером из поста https://nikolaymatrosov.medium.com/dotnet-6-web-api-в-yandex-cloud-serverless-container-21be8824d080

### Deploy

#### Используя CDKTF

Вам понадобится cdktf:
```bash
npm install --global cdktf-cli@0.15.2
```

Далее перейдите в папку `cdk` и выполните:
```bash
 TF_VAR_folderId=b1g*** \
 TF_VAR_token=`yc iam create-token` \
  cdktf deploy --output ../cdktf.out
```
А затем выберите `Approve`.

#### Используя Terraform

Вам понадобится [Terraform](https://www.terraform.io/downloads.html) (версия >= 1.0.0).

Перейдите в папку `terraform` и выполните:

1. Инициализация Terraform:
```bash
terraform init
```

2. Установите переменные окружения:
```bash
export TF_VAR_folder_id=b1g***
export TF_VAR_token=$(yc iam create-token)
```

3. Примените конфигурацию:
```bash
terraform apply
```

4. Подтвердите применение, введя `yes`.

После завершения деплоя, вы получите URL-адреса для контейнера и API Gateway.
