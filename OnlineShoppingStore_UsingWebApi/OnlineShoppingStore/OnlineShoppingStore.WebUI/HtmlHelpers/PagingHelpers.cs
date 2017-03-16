﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        //HtmlHelper Extension Method
        public static MvcHtmlString PageLinksExtention(this HtmlHelper html, Models.PagingInfo pagingInfo,
            Func<int, string> pageUrl)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                if (pageUrl(i) == "/")
                {
                    tag.MergeAttribute("href", pageUrl(i) + "Page1");
                }
                else
                {
                    tag.MergeAttribute("href", pageUrl(i));
                }
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                sb.Append(tag.ToString());
            }

            return MvcHtmlString.Create(sb.ToString());
        }
    }
}