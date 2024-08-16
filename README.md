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
curl -X POST "http://localhost:8282/BCFMPost?BCFMInt=123&BCFMString=BC4M"
```

- #### From Body (use bash&cmd)

```bash
curl -X POST "http://localhost:9090/BCFMPost" -H "Content-Type: application/json" -d '{"BCFMInt": 123, "BCFMString": "BC4M"}'
```
#### Raw JSON for testing 
- ##### ENDPOINT:
  http://localhost:9090/BCFMPost

```bash
{
    "BCFMInt": 32,
    "BCFMString": "BC4M"
}
```


#### GET Request
- Request : 
```bash
http://localhost:9090/BCFM_get
```



#### Health Check
- Request : 
```bash
http://localhost:9090/health
```






# Deployment
Well i used  **AKS** to deploy. For more information about deployment and other stuff check below 👇

## Deployment Details

Check below for the dockerfile and deployment.yaml 📋:

- [dockerfile `dockerfile`](https://github.com/cagri-eroglu/BCFMApi/blob/main/dockerfile)

- [deployment.yaml `deployment.yaml`](https://github.com/cagri-eroglu/BCFMApi/blob/main/deployment.yaml)


## Docker Image 🐳

```bash

```

# Tech Stack

- **Programming Language**: C#
- **Framework**: .NET 8 Core
- **Containerization**: Docker
- **Deployment**: Azure Kubernetes Service (AKS)