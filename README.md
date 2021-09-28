﻿## NetProxy
 
[![CircleCI](https://circleci.com/gh/exeal-es/NetProxy/tree/main.svg?style=svg)](https://circleci.com/gh/exeal-es/NetProxy/tree/main)

NetCore proxy middleware to support [Strangler fit pattern](https://docs.microsoft.com/en-us/azure/architecture/patterns/strangler-fig)

## :pencil: Usage

First, you must add the reverse proxy middleware in your StartUp.cs.

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    ...
    app.UseReverseProxyMiddleware();
    ...
}
```

And also you need to add destination proxy url in your proxy api appsettings.json like this:

```
"ReverseProxy": {
    "DestinationURL": "http://localhost:5001"
  }
```

## :pick: Built Using

- [netcore](https://dotnet.microsoft.com/download)

## :balance_scale: License

MIT
