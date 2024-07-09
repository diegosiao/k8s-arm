
docker-compose -f ./docker-compose.yaml build

docker push raspberrypi:32000/k8s-sbc-asia-weather:dev
docker push raspberrypi:32000/k8s-sbc-europe-weather:dev
docker push raspberrypi:32000/k8s-sbc-southamerica-weather:dev
docker push raspberrypi:32000/k8s-sbc-ui-web:dev

Write-Host '

	Dev images successfully pushed to development registry.

'