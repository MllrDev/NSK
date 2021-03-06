﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nsk.OnlineStore.Web.Site
{
    public static class UrlBuilder
    {
        public static string BuildProductsByCategoryPageUrl(int categoryId, string categoryName)
        {
            return string.Format("/catalog/c/{0}/{1}", categoryId, UrlHelperExtensions.Beautify(categoryName));
        }

        public static string BuildProductsBySupplierPageUrl(int supplierId, string supplierName)
        {
            return string.Format("/catalog/s/{0}/{1}", supplierId, UrlHelperExtensions.Beautify(supplierName));
        }

        public static string BuildProductPageUrl(int productId, string productName)
        {
            return string.Format("/product/{0}/{1}", productId, UrlHelperExtensions.Beautify(productName));
        }

        public static string BuildCategoryThumbnailUrl(int categoryId)
        {
            return string.Format("http://localhost:1866/api/image/product/{0}", categoryId);
        }

        public static string BuildProductThumbnailUrl(int productId)
        {
            return string.Format("http://localhost:1866/api/image/product/{0}", productId);
        }

        public static string BuildSearchResultPageUrl(string query)
        {
            return string.Format("/s/{0}", query);
        }
    }
}