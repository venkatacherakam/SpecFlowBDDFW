using System;
using System.Collections.Generic;
using System.Text;
using TruGreen.Hooks;

namespace TruGreen.Pages
{
    public class Page
    {
        public static BaseWebPage _baseWebPage;
        public static TestActions _testActions;

        public static BaseWebPage BaseWebPage => _baseWebPage ?? (_baseWebPage = new BaseWebPage());
        public static TestActions TestActions => _testActions ?? (_testActions = new TestActions());
    }
}
