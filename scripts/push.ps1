
docker-compose -f ./docker-compose.yaml build

docker push raspberrypi:32000/k8s-sbc-asia-weather:latest
docker push raspberrypi:32000/k8s-sbc-ui-web:latest

Write-Host '

	Local images successfully pushed to development registry.

'