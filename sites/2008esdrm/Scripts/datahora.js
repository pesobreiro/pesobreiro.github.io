// JavaScript Document
<!--
function makeArray()  {
        for (i=0; i<makeArray.arguments.length; i++)
                this[i] = makeArray.arguments [i];
}

function getFullYear(d)  {
        var y = d.getYear();
        if (y < 1000) {y += 1900};
        return y;
}

var days = new makeArray("Domingo","Segunda","Terça","Quarta","Quinta","Sexta","S&aacute;bado")
var months = new makeArray("Janeiro","Fevereiro","Mar&ccedil;o","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro")

function format_time(t)  {
        var Hours = t.getHours();
        var Minutes = t.getMinutes();
        var Seconds = t.getSeconds();
        var Day = t.getDay();
        var Data = t.getDate();
        var Month = t.getMonth();
        var Year = t.getFullYear(t);
        var zone = t.getTimezoneOffset();

        var ampm = "AM";
        if (Hours > 11) {ampm="PM"}

        if (Hours > 12) {Hours -= 12;}

        if (Hours == 0) {Hours = 12;}

/* This contrivance makes minutes and seconds display in two digit format.*/

                if (Minutes < 10) {Minutes = "0"+Minutes;}
                if (Seconds < 10) {Seconds = "0"+Seconds;}

        timeString = "";
        timeString += days[Day];
        timeString += ", ";
        timeString += Data;
        timeString += " de ";		
        timeString += months[Month];
        timeString += " ";
        timeString += Year;
        timeString += " &agrave;s  ";
        timeString += Hours;
        timeString += ":";
        timeString += Minutes;
        timeString += ":";
        timeString += Seconds;

        return timeString;
        }
// -->



        <!--
        m = new Date(document.lastModified);
        d = new Date();
        document.write("&Uacute;ltima actualiza&ccedil;&atilde;o: "+format_time(m)+"<br />");
        // -->
