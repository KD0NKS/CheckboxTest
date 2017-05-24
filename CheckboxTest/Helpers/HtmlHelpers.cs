using System;
using System.Collections.Generic;
//using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.UI;
using System.Text;
using System.Linq.Expressions;
using System.Web.Routing;
using System.Collections;
using System.Web.UI.WebControls;

namespace CheckboxTest.Helpers {
    public static class HtmlHelpers {
        public static MvcHtmlString CheckboxListFor<TModel, TProperty>(this HtmlHelper<TModel> helper
                , Expression<Func<TModel, TProperty>> expression            // Array of selected values
                , Expression<Func<TModel, List<SelectListItem>>> options    // List of options
                , string templateName = null
                , string labelText = null
                , string customHelpText = null
                , object htmlAttributes = null) {
            if(!typeof(TProperty).IsArray) {
                throw new ArgumentException("expression parameter must reference a type of array.");
            }

            StringBuilder sb = new StringBuilder();
                        
            //var opts = Expression.Lambda<Func<List<SelectListItem>>>(((MemberExpression) options.Body).Expression).Compile()();
            
            
            //foreach(var item in options) {
            //    Console.WriteLine();
            //}

            /*
            <input name="RequiredGroupTest" value="7564487c-c66b-46e7-b9a2-3dcf71f4446b" class="checkbox-inline checkbox required-group" data-val="true" data-val-required="The Selected field is required." id="7564487c-c66b-46e7-b9a2-3dcf71f4446b" type="checkbox"><input name="item.Selected" type="hidden" value="false"><label for="CB_1">CB 1</label>                    <br>
            <input name="RequiredGroupTest" value="8047d243-30c7-4efa-822a-09f1b0d50500" class="checkbox-inline checkbox required-group" data-val="true" id="8047d243-30c7-4efa-822a-09f1b0d50500" type="checkbox"><input name="item.Selected" type="hidden" value="false"><label for="CB_2">CB 2</label>                    <br>
            <input name="RequiredGroupTest" value="c693fae6-7d58-4500-ac2b-4dac4c9b34a7" class="checkbox-inline checkbox required-group" data-val="true" id="c693fae6-7d58-4500-ac2b-4dac4c9b34a7" type="checkbox"><input name="item.Selected" type="hidden" value="false"><label for="CB_3">CB 3</label>                    <br>
            <input name="RequiredGroupTest" value="2b7d48e2-b0a4-4ef7-9e0b-a19a221b2dbc" class="checkbox-inline checkbox required-group" data-val="true" id="2b7d48e2-b0a4-4ef7-9e0b-a19a221b2dbc" type="checkbox"><input name="item.Selected" type="hidden" value="false"><label for="CB_4">CB 4</label>                    <br>
             */
            
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}
 