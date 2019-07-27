 if (Request.Cookies["lang"] != null) 
	ViewData["lang"] = Server.HtmlEncode(Request.Cookies["lang"].Value);
