
// Copyright (c)2002 Site Meter, Inc. 

var g_date=new Date();
var g_hours=0;
var g_minutes=0;
var g_r="";
var g_rtype="0";
var g_server ="s12.sitemeter.com"
var g_ip="193.126.182.208";

// Get the User Agent Name
var g_agent = navigator.appName;

// if g_frames is true then try getting the framed referral (with out error checking)
if (typeof(g_frames) != "undefined")
	if (g_frames)
		g_r=top.document.referrer;

// Get the referral for non-multi-domained-framed sites using a Netscape browser
if ((g_r == "") || (g_r == "[unknown origin]") || (g_r == "unknown") || (g_r == "undefined"))
	if (document["parent"] != null) 
		if (parent["document"] != null) // ACCESS ERROR HERE!
			if (parent.document["referrer"] != null) 
				if (typeof(parent.document) == "object")
				{
					g_rtype="1";
					g_r=parent.document.referrer; 
				}

// Get the referral for the current document if a framed referral wasn't found
if ((g_r == "") || (g_r == "[unknown origin]") || (g_r == "unknown") || (g_r == "undefined"))
	if (document["referrer"] != null) 
	{
		g_rtype="4";
		g_r = document.referrer;
	}

// Get the hours
if (g_date)
	g_hours=g_date.getHours();

// Get the minutes
if (g_date)
	g_minutes=g_date.getMinutes();

// Convert all the 'unknown's into blank
if ((g_r == "") || (g_r == "[unknown origin]") || (g_r == "unknown") || (g_r == "undefined"))
	g_r = "";

// Create the image url and write it into the page. 
document.write("<a href=\"http://" + g_server + "/");
document.write("stats.asp?site="+site+"\" target=_top>");
document.write("<img src=\"http://" + g_server + "/");
document.write("meter.asp?site="+site); 
document.write("&refer="+escape(g_r));
if (g_ip != "")
	document.write("&ip="+g_ip);
document.write("&hours="+g_hours);
document.write("&minutes="+g_minutes);
document.write("&rtype="+g_rtype);
document.write("\" border=0 title=\"Site Meter\"></a>");

// if g_leavenoscript is true then DO NOT try to comment-out the Site Meter NOSCRIPT tags
// that follow the Site Meter script reference in the page
if (typeof(g_leavenoscript) == "undefined")
	document.write("<!" + "--");