## API Reference

#### POST data
- Request : 
```http
  POST 
```

| Parameter              | Type         | Description                            |
| :--------              | :-------     | :-------------------------             |
| `intBasedProperty`     | `int`        | **Optional**. An integer value.        |
| `stringBasedProperty`  | `string`     | **Optional**. A string value.          |
| `data`                 | `PostBCFMDto`| **Optional**. A JSON object containing       IntBasedProperty and StringBasedProperty.          |

#### BCFM_get
- Request : 
```http
  GET /api/health
```
- Response : 
```http
{
  "msg": "BC4M"
}
```
