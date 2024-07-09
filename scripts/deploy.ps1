
# Check if the context is correct

kubectl delete namespace world

kubectl create namespace world

kubectl apply -f ./manifests
