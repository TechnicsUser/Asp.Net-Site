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
          //  if(!filterContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = filterContext.HttpContext.User.Identity.GetUserId();

            var context = new SiteDataContext();
            var notifications = context.Notifications
               .Where(n => n.UserId == userId)
                .Where(n => n.IsDismissed == false)
                .GroupBy(n => n.UserId)
                .Select(g => new NotificationViewModel {
                    Count = g.Count(),
                    NotificationType = g.Key.ToString(),
                    BadgeClass =   "info"
                   
                    });

            filterContext.Controller.ViewBag.Notifications = notifications;
            }
        }
    }

//var context = new SiteDataContext();
//var notifications = context.Notifications
//   .Where(n => n.UserId == userId)
//    .Where(n => n.IsDismissed == false)
//    .GroupBy(n => n.NotificationType)
//    .Select(g => new NotificationViewModel
//    {
//        Count = g.Count(),
//        NotificationType = g.Key.ToString(),
//        BadgeClass = NotificationType.Email == g.Key
//            ? "success"
//            : "info"
//    });