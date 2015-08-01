using System.Web;
using System.Web.Optimization;

namespace Bois.Web
{
    public class BundleConfig
    {
        // Pour plus d’informations sur le Bundling, accédez à l’adresse http://go.microsoft.com/fwlink/?LinkId=254725 (en anglais)
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();


            bundles.Add(new StyleBundle("~/bundles/CustomStyle").Include(
               "~/Content/plugins/datatables/jquery.dataTables.css",
               "~/Content/plugins/datatables/extensions/Responsive/css/dataTables.responsive.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l’outil de génération sur http://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/plugins").Include(
                "~/Content/plugins/iCheck/flat/blue.css",
                "~/Content/plugins/morris/morris.css",
                "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                "~/Content/plugins/datepicker/datepicker3.css",
                "~/Content/plugins/daterangepicker/daterangepicker-bs3.css",
                "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                ));

            bundles.Add(new StyleBundle("~/Content/dist").Include(
               "~/Content/dist/css/AdminLTE.min.css",
               "~/Content/dist/css/skins/_all-skins.min.css" 
               ));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
              "~/Content/bootstrap/css/bootstrap.min.css",
              "~/Content/bootstrap/fonts/font-awesome.min.css",
               "~/Content/bootstrap/ionicons.min.css" 
              ));

            bundles.Add(new ScriptBundle("~/js/bootstrap").Include(
                       "~/Content/bootstrap/js/bootstrap.min.js" ));

            bundles.Add(new ScriptBundle("~/js/custom").Include(
                    "~/Content/ajax/raphael-min.js",
                    "~/Content/ajax/bridge.js"));


            bundles.Add(new ScriptBundle("~/js/plugins").Include(
              "~/Content/plugins/morris/morris.min.js",
              "~/Content/plugins/sparkline/jquery.sparkline.min.js",
              "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
              "~/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
              "~/Content/plugins/knob/jquery.knob.js",
              "~/Content/plugins/daterangepicker/daterangepicker.js",
              "~/Content/plugins/fastclick/fastclick.min.js",
              "~/Content/plugins/datepicker/bootstrap-datepicker.js",
              "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
              "~/Content/plugins/slimScroll/jquery.slimscroll.min.js"
                                                                ));

            bundles.Add(new ScriptBundle("~/js/dist").Include(
               "~/Content/dist/js/pages/dashboard.js",
               "~/Content/dist/js/demo.js",
               "~/Content/dist/js/app.min.js"
               ));

        }

        
    }
}