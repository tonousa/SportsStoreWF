﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore.Controls
{
    public class VInput : WebControl
    {
        private string nspace = "SportsStore.Controls";
        private string model = "Order";

        public string Namespace
        {
            get { return nspace; }
            set { nspace = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Property { get; set; }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Id, Property.ToLower());
            output.AddAttribute(HtmlTextWriterAttribute.Name, Property.ToLower());

            Type modelType = Type.GetType(string.Format("{0}.{1}", Namespace, Model));
            PropertyInfo propInfo = modelType.GetProperty(Property);
            var attr = propInfo.GetCustomAttribute<RequiredAttribute>(false);

        }
    }
}
