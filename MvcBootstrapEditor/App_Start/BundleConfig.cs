using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcBootstrapEditor.App_Start
{
    public class BundleConfig
    {
        /// <summary>
        /// 捆绑压缩
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            //前面是虚拟的名称
            bundles.Add(new StyleBundle("~/CFS/css").Include(
                "~/Content/bootstrap.css", "~/Content/font-awesome.css",
                "~/Scripts/summernote/summernote.css"));

            //打包SummerNote
          //  bundles.Add(new StyleBundle("~/CFS/summernote").Include("~/Scripts/summernote/summernote.css"));

            //打包Jquery和Bootstrap
            bundles.Add(new ScriptBundle("~/CFS/base").Include("~/Scripts/jquery-1.9.1.js", "~/Scripts/bootstrap.js","~/Scripts/summernote/summernote.js", "~/Scripts/MyEditorJS.js"));

            //bundles.Add(new ScriptBundle("~/CFS/summernote").Include("~/Scripts/summernote/summernote.js"));
        }
    }
}