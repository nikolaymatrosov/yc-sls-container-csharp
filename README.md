Это репозиторий с примером из поста https://nikolaymatrosov.medium.com/dotnet-6-web-api-в-yandex-cloud-serverless-container-21be8824d080

### Deploy

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