DigiCert Retail API Library for .NET
===

This is a quick library for the [DigiCert Retail API](https://www.digicert.com/clients/rest/docs/retail/). You'll need to signup for a DigiCert account and create an API Key to use it.

This library is actually mostly generated from a [Swagger](https://swagger.io/) file I created that covers most of the retail API. It's generated using the following:

> npm install -g autorest

> autorest -Namespace DigiCertSharp -Input swagger.json -AddCredentials true -CodeGenerator CSharp

It can be using either Visual Studio 2017 or .NET Core 1.0+. 

It supports .Net Framework 4.5.2 as well as .Net Standard 1.4 (.Net Core 1.0+/.Net Framework 4.6.1+). This is due to the dependency on [Microsoft.Rest.ClientRuntime](https://www.nuget.org/packages/Microsoft.Rest.ClientRuntime/).