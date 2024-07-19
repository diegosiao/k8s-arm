
# latest is the default tag present on manifests

cd .\..\Kubernetes.Sbc.Weather.Service
.\publish.ps1 "latest"

cd .\..\Kubernetes.Sbc.Ui.Web
.\publish.ps1 "latest"

cd .\..\scripts

"
	Container images pushed to local registry
"