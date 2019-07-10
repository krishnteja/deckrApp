﻿using System.Web.Http;

namespace DeCKR_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "SingleContract",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "UserContracts",
                routeTemplate: "api/{controller}/{action}/{employeeId}",
                defaults: new { id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                 name: "SingleSecurityGroup",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional }
                 );

            config.Routes.MapHttpRoute(
                  name: "UserSecurityGroups",
                  routeTemplate: "api/{controller}/{action}/{employeeId}",
                  defaults: new { id = RouteParameter.Optional }
                  );

            config.Routes.MapHttpRoute(
                 name: "SingleTraining",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional }
                 );

            config.Routes.MapHttpRoute(
              name: "UserTrainings",
              routeTemplate: "api/{controller}/{action}/{employeeId}",
              defaults: new { id = RouteParameter.Optional }
              );
        }
    }
}
