
cd Kubernetes.Sbc.Asia.Weather 

docker build . -t kubernetessbcasiaweather:dev

docker tag kubernetessbcasiaweather:dev raspberrypi:32000/kubernetessbcasiaweather:latest

docker push raspberrypi:32000/kubernetessbcasiaweather:latest

cd ..