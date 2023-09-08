# Securing Microservices with IdentityServer4, OAuth2 and OpenID Connect fronted by Ocelot API Gateway

**UDEMY COURSE WITH DISCOUNTED - Step by Step Development of this repository -> https://www.udemy.com/course/secure-net-microservices-with-identityserver4-oauth2openid/?couponCode=SEPT23**

**Check Explanation of this Repository on Medium -> https://medium.com/@mehmetozkaya/securing-microservices-with-identityserver4-with-oauth2-and-openid-connect-fronted-by-ocelot-api-49ea44a0cf9e**

### Overall Picture
See the overall picture of **implementations on secure microservices with using standalone Identity Server 4 and backing with Ocelot API Gateway** on real-world **e-commerce microservices** project;

![Securing Microservices with IS4](https://user-images.githubusercontent.com/1147445/97865031-9a4c9f00-1d1a-11eb-8dee-80fc600decfa.png)

In this repository, you will see that how to secure microservices with using **standalone Identity Server 4** and backing with **Ocelot API Gateway**. We’re going to protect our ASP.NET Web MVC and API applications with using **OAuth 2 and OpenID Connect** in IdentityServer4. Securing your web application and API with tokens, working with claims, authentication and authorization middlewares and applying policies, and so on.

![Overall Picture of Repository](https://user-images.githubusercontent.com/1147445/97865027-991b7200-1d1a-11eb-927e-3f5580a7f5b5.png)

### Movies.API
First of all, we are going to develop **Movies.API** project and protect this API resources with **IdentityServer4 OAuth 2.0 implementation**. Generate **JWT Token** with client_credentials from IdentityServer4 and will use this token for securing Movies.API protected resources.

### Movies.MVC
After that, we are going to develop Movies.MVC Asp.Net project for Interactive Client of our application. This Interactive Movies.MVC Client application will be secured with OpenID Connect in IdentityServer4. Our client application pass credentials with logging to an Identity Server and receive back a JSON Web Token (JWT).

### Identity Server
Also, we are going to develop centralized standalone **Authentication Server** and **Identity Provider** with implementing IdentityServer4 package and the name of microservice is Identity Server.
Identity Server4 is an open source framework which implements **OpenId Connect and OAuth2 protocols** for .Net Core.
With Identity Server, we can provide authentication and access control for our web applications or Web APIs from a single point between applications or on a user basis.

### Ocelot API Gateway
Lastly, we are going to develop **Ocelot API Gateway** and make secure protected API resources over the Ocelot API Gateway with transferring **JWT web tokens**.
Once the client has a bearer token it will call the API endpoint which is fronted by Ocelot. Ocelot is working as a reverse proxy.
After Ocelot reroutes the request to the internal API, it will present the token to Identity Server in the **authorization pipeline**. If the client is authorized the request will be processed and a list of movies will be sent back to the client.

Also over these picture, we have also apply the **claim based authentications**.

## Installation
Follow these steps to get your development environment set up:
1. Check All projects run profiles. One by one Right Click the project file, open Properties window and check the debug section. Launch Profile should be the "Project" and App URLs should be the same as big picture.
2. For all projects, one by one, Set a Startup project and see the Run profile on the Run button. Change the default running profile to IIS Express to Project name.
3. Multiple startup projects. Right click the solution, open Properties, and set Multiple startup project and Start all 4 application click apply and ok.
4. Now you can run the overall application with Click Start button or F5.
You will see 4 project console window and 1 chrome window for client application.

* **Movies.Client -> https://localhost:5002/**

Check the application with logging the system with below credentials;

* **username - password 1 : alice - a1**
* **username - password 2 : bob - b1**


