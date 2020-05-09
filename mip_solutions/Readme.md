
### Certificate Error while Building

``` varlog
Microsoft.AspNetCore.Server.Kestrel.Https.Internal.HttpsConnectionMiddleware: Error: The ASP.NET Core developer certificate is in an invalid state. To fix this issue, run the following commands 'dotnet dev-certs https --clean' and 'dotnet dev-certs https' to remove all existing ASP.NET Core development certificates and create a new untrusted developer certificate. On macOS or Windows, use 'dotnet dev-certs https --trust' to trust the new certificate.
```

Follow following commands: </br>
 * `dotnet dev-certs https --clean`
 * `dotnet dev-certs https`
 * `dotnet dev-certs https --trust`