﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Filters {
    public class NotificationFilter : ActionFilterAttribute {
        public override void OnActionExecuted(ActionExecutedContext filterContext) {
            if(!filterContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = filterContext.HttpContext.User.Identity.GetUserId();

            var context = new SiteDataContext();
            var notifications = context.Notifications
               // .Where(n => n.UserId == userId)
                .Where(n => n.Title == "John Smith was added to the system.")
                .GroupBy(n => n.NotificationType)
                .Select(g => new NotificationViewModel {
                    Count = g.Count(),
                    NotificationType = g.Key.ToString(),
                    BadgeClass = NotificationType.Email == g.Key
                        ? "success"
                        : "info"
                    });

            filterContext.Controller.ViewBag.Notifications = notifications;
            }
        }
    }