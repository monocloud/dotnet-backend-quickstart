<div align="center">
  <a href="https://www.monocloud.com?utm_source=github&utm_medium=dotnet_backend_quickstart" target="_blank" rel="noopener noreferrer">
    <picture>
      <img src="https://raw.githubusercontent.com/monocloud/dotnet-backend-quickstart/refs/heads/main/banner.svg" alt="MonoCloud Banner">
    </picture>
  </a>
  <div align="right">
    <a href="https://www.nuget.org/packages/MonoCloud.Backend" target="_blank">
      <img src="https://img.shields.io/nuget/v/MonoCloud.Backend" alt="NuGet" />
    </a>
    <a href="https://opensource.org/licenses/MIT">
      <img src="https://img.shields.io/:license-MIT-blue.svg?style=flat" alt="License: MIT" />
    </a>
  </div>
</div>

<br />

## .NET Backend Quickstart

A **minimal ASP.NET Core (minimal API) example** showing how to protect API endpoints with access token validation using MonoCloud.

## What this repo shows

- MonoCloud access token validation with ASP.NET Core
- Endpoint protection via the standard authentication and authorization pipeline
- Accessing the authenticated user's claims

Built with [**`MonoCloud.Backend`**](https://www.nuget.org/packages/MonoCloud.Backend).

## Prerequisites

Before you begin:

1. In the [MonoCloud Dashboard](https://dashboard.monocloud.com/), create a new **API**
2. Set the **Audience** (for example `https://api.example.com`) — this uniquely identifies your API
3. Add a scope named `example-api` and mark the scope as a default scope

You'll also need the [.NET SDK](https://dotnet.microsoft.com/download) (8.0 or later).

## Configure the application

This repo reads its configuration from `appsettings.json`. Replace the placeholders with values from your API:

```json
"MonoCloud": {
  "TenantDomain": "https://<your-domain>",
  "Audience": "https://<your-api-audience>"
}
```

> Do not commit real secrets. For production, use environment variables, user secrets, or a secure secret store.

## Run locally

```bash
dotnet run
```

The server starts on `http://localhost:3000`.

## Test

```bash
curl -H "Authorization: Bearer <your-access-token>" http://localhost:3000/api/protected
```

## 📘 Learn more

-   **.NET Backend Quickstart:** [https://www.monocloud.com/docs/quickstarts/dotnet-backend](https://www.monocloud.com/docs/quickstarts/dotnet-backend?utm_source=github&utm_medium=dotnet_backend_quickstart)
-   **.NET Backend SDK Docs:** [https://www.monocloud.com/docs/sdks/dotnet-backend](https://www.monocloud.com/docs/sdks/dotnet-backend/index?utm_source=github&utm_medium=dotnet_backend_quickstart)
-   **API Reference:** [https://monocloud.github.io/backend-dotnet](https://monocloud.github.io/backend-dotnet?utm_source=github&utm_medium=dotnet_backend_quickstart)

## 🤝 Contributing & Support

### Issues & Feedback

- Use **GitHub Issues** for bug reports and feature requests.
- For tenant or account-specific help, contact MonoCloud Support through your dashboard.

### Security

Do **not** report security issues publicly. Please follow the contact instructions at: [https://www.monocloud.com/contact](https://www.monocloud.com/contact?utm_source=github&utm_medium=dotnet_backend_quickstart)

## License

Licensed under the **MIT License**. See the included [`LICENSE`](./LICENSE) file.