<div align="center">
  <a href="https://www.monocloud.com?utm_source=github&utm_medium=dotnet_api_authentication_quickstart" target="_blank" rel="noopener noreferrer">
    <picture>
      <img src="https://raw.githubusercontent.com/monocloud/dotnet-api-authentication-quickstart/refs/heads/main/banner.svg" alt="MonoCloud Banner">
    </picture>
  </a>
  <div align="right">
    <a href="https://www.nuget.org/packages/MonoCloud.Authentication.Api" target="_blank">
      <img src="https://img.shields.io/nuget/v/MonoCloud.Authentication.Api" alt="NuGet" />
    </a>
    <a href="https://opensource.org/licenses/MIT">
      <img src="https://img.shields.io/:license-MIT-blue.svg?style=flat" alt="License: MIT" />
    </a>
  </div>
</div>

<br />

## .NET API Authentication Quickstart

A **minimal ASP.NET Core (minimal API) example** showing how to protect API endpoints with access token validation using MonoCloud.

## What this repo shows

- MonoCloud access token validation with ASP.NET Core
- Endpoint protection via the standard authentication and authorization pipeline
- Accessing the authenticated user's claims

Built with [**`MonoCloud.Authentication.Api`**](https://www.nuget.org/packages/MonoCloud.Authentication.Api).

## Prerequisites

Before you begin:

1. In the [MonoCloud Dashboard](https://dashboard.monocloud.com/), create a new **API**
2. Set the **Audience** (for example `https://api.example.com`) — this uniquely identifies your API
3. Add a scope named `example-api` and mark the scope as a default scope

You'll also need the [.NET SDK](https://dotnet.microsoft.com/download) (10.0 or later).

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

- **Documentation:** [https://www.monocloud.com/docs](https://www.monocloud.com/docs?utm_source=github&utm_medium=dotnet_api_authentication_quickstart)
- **Quickstart:** [https://www.monocloud.com/docs/quickstarts/dotnet-api-authentication](https://www.monocloud.com/docs/quickstarts/dotnet-api-authentication?utm_source=github&utm_medium=dotnet_api_authentication_quickstart)
- **SDK Reference:** [https://www.monocloud.com/docs/sdks/dotnet-api-authentication](https://www.monocloud.com/docs/sdks/dotnet-api-authentication?utm_source=github&utm_medium=dotnet_api_authentication_quickstart)
- **API Reference:** [https://monocloud.github.io/api-authentication-dotnet](https://monocloud.github.io/api-authentication-dotnet?utm_source=github&utm_medium=dotnet_api_authentication_quickstart)

## 🤝 Contributing & Support

### Issues & Feedback

- Use **GitHub Issues** for bug reports and feature requests.
- For tenant or account-specific help, contact MonoCloud Support through your dashboard.

### Security

Do **not** report security issues publicly. Please follow the contact instructions at: [https://www.monocloud.com/contact](https://www.monocloud.com/contact?utm_source=github&utm_medium=dotnet_api_authentication_quickstart)

## License

Licensed under the **MIT License**. See the included [`LICENSE`](./LICENSE) file.