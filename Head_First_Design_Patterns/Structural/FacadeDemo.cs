using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Head_First_Design_Patterns;

namespace Head_First_Design_Patterns.FacadeDemo
{
    public class FacadeDemo
    {
        //static void Main()
        //{
        //    MigrationBL migrationBL = new MigrationBL(new FilterBL(), new HtmlParserBL(), new KenticoBL(),new WebsiteMigrationInput());
        //    migrationBL.StartMigration();
        //}
    }

    public class MigrationBL
    {
        private FilterBL _filterBL = null;
        private HtmlParserBL _htmlParserBL = null;
        private KenticoBL _kenticoBL = null;
        public WebsiteMigrationInput WebSiteMigrationInput { get; set; }

        public MigrationBL(FilterBL filterBL, HtmlParserBL htmlParserBL, KenticoBL kenticoBL, WebsiteMigrationInput webSiteMigrationInput)
        {
            _filterBL = filterBL;
            _htmlParserBL = htmlParserBL;
            _kenticoBL = kenticoBL;
            WebSiteMigrationInput = webSiteMigrationInput;
        }

        public void StartMigration()
        {
            _filterBL.Filter(WebSiteMigrationInput);
            _htmlParserBL.Parse();
            _kenticoBL.DoKenticoStuff();
        }
    }


    public class WebsiteMigrationInput
    {

    }

    public class FilterBL
    {
        public void Filter(WebsiteMigrationInput input)
        {

        }
    }

    public class HtmlParserBL
    {
        public void Parse()
        {

        }
    }

    public class KenticoBL
    {
        public void DoKenticoStuff()
        {

        }
    }
}
