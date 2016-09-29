using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Support.Forms.Mvc.ViewModels.Fields
{
    public class CheckboxListField : Sitecore.Forms.Mvc.ViewModels.Fields.CheckboxListField
    {
        public override void SetValueFromQuery(string valueFromQuery)
        {
            if (string.IsNullOrEmpty(valueFromQuery))
            {
                return;
            }
            string[] array = valueFromQuery.Split(new char[]
			{
				','
			});
            string[] array2 = array;
            for (int i = 0; i < array2.Length; i++)
            {
                string value = array2[i];
                if (this.Items != null)
                {
                    foreach (SelectListItem current in this.Items)
                    {
                        if (current.Value.Equals(value, StringComparison.OrdinalIgnoreCase))
                        {
                            current.Selected = true;
                        }
                    }
                }
            }
        }
    }
}