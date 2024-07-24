

kubectl delete namespace world
kubectl create namespace world

.\publish.ps1

kubectl apply -f ./../manifests/
