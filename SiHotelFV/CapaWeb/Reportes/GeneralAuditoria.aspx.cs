﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWeb.Reportes
{
    public partial class GeneralAuditoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void imgEliminar_Click(object sender, EventArgs e)
        {

            Response.Redirect("ReporteAuditoria.aspx");
        }
    }
}