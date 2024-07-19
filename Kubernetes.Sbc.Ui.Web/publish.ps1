param (
    [string]$tag = "$(Get-Date -Format "yyyyMMddHHmmss")"
)

$image = "raspberrypi:32000/k8s-sbc-ui-web:develop-$(git rev-parse --short HEAD)-$($tag)"

dotnet publish --configuration Release --runtime linux-arm64
if ($LASTEXITCODE -ne 0) { Exit 1 }

docker build . -t $image
if ($LASTEXITCODE -ne 0) { Exit 1 }

docker push $image
if ($LASTEXITCODE -ne 0) { Exit 1 }

kubectl set image deployment/world-ui world-ui=$image -n world
