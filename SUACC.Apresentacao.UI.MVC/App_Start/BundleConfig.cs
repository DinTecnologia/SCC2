using System.Web;
using System.Web.Optimization;

namespace SUACC.Apresentacao.UI.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/globaljs").Include(
                      "~/Content/assets/js/plugins/loaders/pace.min.js",
                      "~/Content/assets/js/core/libraries/jquery.min.js",
                      "~/Content/assets/js/core/libraries/bootstrap.min.js",
                      "~/Content/assets/js/plugins/loaders/blockui.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/Content/globalthemajs").Include(
                      "~/Content/assets/js/plugins/visualization/d3/d3.min.js",
                      "~/Content/assets/js/plugins/visualization/d3/d3_tooltip.js",
                      "~/Content/assets/js/plugins/forms/styling/switchery.min.js",
                      "~/Content/assets/js/plugins/forms/styling/uniform.min.js",
                      "~/Content/assets/js/plugins/forms/selects/bootstrap_multiselect.js",
                      "~/Content/assets/js/plugins/ui/moment/moment.min.js",
                      "~/Content/assets/js/plugins/pickers/daterangepicker.js",
                      "~/Content/assets/js/plugins/velocity/velocity.min.js",
                      "~/Content/assets/js/plugins/velocity/velocity.ui.min.js",
                      "~/Content/assets/js/plugins/buttons/spin.min.js",
                      "~/Content/assets/js/plugins/buttons/ladda.min.js",
                      "~/Content/assets/js/pages/components_buttons.js",
                      "~/Content/assets/js/core/app.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/globalcss").Include(
                      "~/Content/assets/css/icons/icomoon/styles.css",
                      "~/Content/assets/css/bootstrap.css",
                      "~/Content/assets/css/core.css",
                      "~/Content/assets/css/components.css",
                      "~/Content/assets/css/colors.css"
                      ));
        }
    }
}
