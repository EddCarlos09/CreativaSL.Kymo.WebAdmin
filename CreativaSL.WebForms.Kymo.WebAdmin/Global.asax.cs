﻿using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["strConnection"];
            Comun.Conexion = settings.ConnectionString;
            Comun.IDUsuario = "Sistema Administrador Kymo";
        }
    }
}