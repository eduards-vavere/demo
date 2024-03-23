# demo

Code for the demo:

"Intro: C# + Containers + Azure"
 
Create your first C# container app and run it on Azure.
 
30min GET STARTED:
- C# WebApi in Visual Studio
- Add docker support using Visual Studio
- Dockerfile explainer
- Local dev using Docker Desktop
- Push to Dockerhub (free)
 
Open Azure
- Create Container App
- Deploy your docker image to app
- Configure ingress
- Configure scaling (Autoscale to 0)
 
15min ORCHESTRATE:
- C# WebApi will use redis
- Add docker compose support using Visual Studio
- Add local redis
- Run docker compose using Visual Studio
- Add redis in Azure Container app env
- Deploy
 
Under the hood Azure Container Apps (ACA) run on AKS (Azure Kubernetes Service). ACA abstracts away the difficulties of managing a kubernetes cluster and let's you build distributed microsoervice architectures.