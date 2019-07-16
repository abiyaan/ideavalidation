using System.Web;
using System.Web.Optimization;

namespace IdeaValidation.backoffice
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/smartadmin").IncludeDirectory("~/content/css", "*.min.css"));

            bundles.Add(new ScriptBundle("~/scripts/smartadmin").Include(
             "~/scripts/app.config.min.js",
             "~/scripts/plugin/jquery-touch/jquery.ui.touch-punch.min.js",
             "~/scripts/bootstrap/bootstrap.min.js",
             "~/scripts/notification/SmartNotification.min.js",
             "~/scripts/smartwidgets/jarvis.widget.min.js",
             "~/scripts/plugin/jquery-validate/jquery.validate.min.js",
             //"~/scripts/plugin/masked-input/jquery.maskedinput.min.js",
             //"~/scripts/plugin/select2/select2.min.js",
             //"~/scripts/plugin/bootstrap-slider/bootstrap-slider.min.js",
             //"~/scripts/plugin/bootstrap-progressbar/bootstrap-progressbar.min.js",
             //"~/scripts/plugin/msie-fix/jquery.mb.browser.min.js",
             //"~/scripts/plugin/fastclick/fastclick.min.js",
             "~/scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/scripts/datatables").Include(
                "~/scripts/plugin/datatables/jquery.dataTables.min.js",
                "~/scripts/plugin/datatables/dataTables.colVis.min.js",
                "~/scripts/plugin/datatables/dataTables.tableTools.min.js",
                "~/scripts/plugin/datatables/dataTables.bootstrap.min.js",
                "~/scripts/plugin/datatable-responsive/datatables.responsive.min.js"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
