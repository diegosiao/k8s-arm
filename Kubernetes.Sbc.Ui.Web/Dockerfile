# See https://aka.ms/customizecontainer to learn how to customize your debug container 
# and how Visual Studio uses this Dockerfile to build your images for faster debugging.


# https://mcr.microsoft.com/en-us/product/dotnet/aspnet/tags
FROM mcr.microsoft.com/dotnet/aspnet:8.0.6-alpine3.20-arm64v8
USER app

COPY bin/Release/net8.0/linux-arm64 /app

CMD ["dotnet", "/app/Kubernetes.Sbc.Ui.dll"]