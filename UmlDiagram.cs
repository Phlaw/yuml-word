using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;



namespace WordAddIn1
{
    public class UmlDiagram
    {
        public String[] script = defaultClass;
        static String baseUrl = "http://yuml.me/diagram/";
        static String[] defaultClass = 
        {
            "# Cool UML Diagram",
            "[Customer]+1->*[Order]",
            "[Order]++1-items >*[LineItem]",
            "[Order]-0..1>[PaymentMethod]"
        };

        static String[] defaultUsecase = 
        {
            "[User]-(Login)",
            "[User]-(Logout)",
            "(Login)<(Reminder)",
            "(Login)>(Captcha)"
        };

        static String[] defaultActivity =
        {
            "(start)-><d1>logged in->(Show Dashboard)->|a|->(end)",
            "<d1>not logged in->(Show Login)->|a|"
        };

        private String style = "scruffy";
        // non scruffy urls simply have this space empty
        public String Style// "scruffy" or "square"
        {
            set
            {
                if (value.Equals("scruffy") | value.Equals("square"))
                    style = value;
            }
            get{return style;}
        }

        private String type = "class";
        public String Type  // class, usecase or activity
        {
            set
            {
                if (value.Equals("class") | value.Equals("usecase") | value.Equals("activity"))
                type = value;
            }
            get { return type; }
        }
        public String fileType = ".png"; // .png, .jpg or .pdf

        public UmlDiagram()
        {
            style = "scruffy";
            type = "class";
            fileType = ".png";
        }

        public UmlDiagram(String type)
        {
            this.type = type;
            if (type == "class") this.script = defaultClass;
            if (type == "activity") this.script = defaultActivity;
            if (type == "usecase") this.script = defaultUsecase;
        }


        public String getDiagramUrl()
        {
            String url = baseUrl;
            if (style != null && style != "" && style !="square") url += style + "/";//square style has no "/style/" in the url.
            url += type + "/";

            char[] delim = " ,".ToCharArray();
            foreach (String line in script)
            {
                //trim out comments
                int comment = line.IndexOf('#');
                String uncomment;
                if (comment >= 0)
                {
                    uncomment = line.Substring(0, comment);
                }
                else uncomment = line;

                //trim out spaces and commas
                uncomment = uncomment.Trim(delim);

                if(uncomment.Length >0) url += uncomment + ",";
            }
            url = url.Trim(delim);

            url += fileType;

            return url;
        }

        /**
         * Diagram data is stored in the InlineShape's  alt-text for persistance. 
         * yuml; script:line,line,line; style:scruffy;  ???
         * TODO better serialization, probably via JSON
         */
        public String getAltTextString()
        {
            return JsonConvert.SerializeObject(this);
            /**String alt = "yuml; ";
            
            alt += "script:";
            foreach (String line in script)
            {
                alt += line + ",";
            }
            alt += "; ";

            alt += "style:" + style + ";";
            alt += "type:" + type + ";";
            return alt;*/
        }

        public static UmlDiagram parseAltText(String alt)
        {
            //quickly check that alt text is present and is yuml.
            if (alt == null) return null;
            try
            {
                return  JsonConvert.DeserializeObject<UmlDiagram>(alt);
            }
            catch (Exception e)
            {
                return null;
            }
            
            /**
            if (!alt.StartsWith("yuml")) return null;

            char[] delim = " ;:,".ToCharArray();
    
            UmlDiagram uml = new UmlDiagram();
            String[] segments = alt.Split(';');
            foreach (String segment in segments)
            {
                int colon = segment.IndexOf(':');
                if(colon >=0){
                    String key = segment.Substring(0, colon).Trim(delim);
                    String value = segment.Substring(colon + 1, segment.Length - colon-1).Trim(delim);
                    if (key == "style") uml.style = value;
                    if (key == "type") uml.type = value;
                    if (key == "script") uml.script = value.Split(',');
                }
            }

            return uml;
             */
        }

    }
}
