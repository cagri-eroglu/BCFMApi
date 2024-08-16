# API Reference

## Usage/Examples
#### POST Request

| Parameter              | Type         | Description                            |
| :--------              | :-------     | :-------------------------             |
| `BCFMInt`     | `int`        | integer value just for testing purpose.        |
| `BCFMString`  | `string`     | string value just for testing purpose.          |
| `data`                 | `PostBCFMDto`| JSON object containing       BCFMInt and BCFMString.          |
- #### From Query (use bash&cmd)

```bash
curl -X POST "http://4.154.249.241:9090?BCFMInt=123&BCFMString=BC4M"
```

- #### From Body (use bash&cmd)

```bash
curl -X POST "http://4.154.249.241:9090/BCFMPost" -H "Content-Type: application/json" -d '{"BCFMInt": 123, "BCFMString": "BC4M"}'
```
#### Raw JSON for testing 
- ##### ENDPOINT:
  http://4.154.249.241:9090/BCFMPost

```bash
{
    "BCFMInt": 32,
    "BCFMString": "BC4M"
}
```


#### GET Request
- Request : 
```bash
http://4.154.249.241:9090/BCFMGet
```



#### Health Check
- Request : 
```bash
http://4.154.249.241:9090/health
```






# Deployment
Well i used  **AKS** to deploy. For more information about deployment and other stuff check below 👇

## Deployment Details

```bash
    Name:                   bcfmapi-deployment
Namespace:              default
CreationTimestamp:      Thu, 15 Aug 2024 18:39:38 -0700
Labels:                 <none>
Annotations:            deployment.kubernetes.io/revision: 4
                        kubernetes.io/change-cause: Initial deployment of the app
Selector:               app=bcfmapi
Replicas:               3 desired | 3 updated | 3 total | 3 available | 0 unavailable
StrategyType:           RollingUpdate
MinReadySeconds:        0
RollingUpdateStrategy:  25% max unavailable, 25% max surge
Pod Template:
  Labels:  app=bcfmapi
           app.kubernetes.io/name=bcfmapi
           env=prod
  Containers:
   bcfmapi:
    Image:      cagrieroglu/bcfmapi:v1
    Port:       80/TCP
    Host Port:  0/TCP
    Limits:
      cpu:     200m
      memory:  200Mi
    Requests:
      cpu:     100m
      memory:  100Mi
    Environment:
      ASPNETCORE_URLS:  http://+:80
    Mounts:             <none>
  Volumes:              <none>
Conditions:
  Type           Status  Reason
  ----           ------  ------
  Available      True    MinimumReplicasAvailable
  Progressing    True    NewReplicaSetAvailable
```


Check below for the dockerfile and deployment.yaml 📋:

- [dockerfile `dockerfile`](https://github.com/cagri-eroglu/BCFMApi/blob/main/dockerfile)

- [deployment.yaml `deployment.yaml`](https://github.com/cagri-eroglu/BCFMApi/blob/main/deployment.yaml)


## Docker Image 🐳

```bash
    docker pull cagrieroglu/bcfmapi:v1
```

# Tech Stack

- **Programming Language**: C#
- **Framework**: .NET 8 Core
- **Containerization**: Docker
- **Deployment**: Azure Kubernetes Service (AKS)