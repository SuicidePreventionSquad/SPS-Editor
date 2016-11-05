using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SPS_Editor
{
    public class JData
    {
        public string[] Questions { get; set; }
        public string[] Responses { get; set; }
        public string[] Error { get; set; }
        public string[] Contacts { get; set; }
    }

    public class JSONHelper
    {
        public static JData ReadData(string filename)
        {
            JData jData = new JData();
            List<string> jsonItems = new List<string>();
            int counter = 1;

            try
            {
                using (JsonTextReader jr = new JsonTextReader(new StreamReader(filename)))
                {
                    while (jr.Read())
                    {

                        if (jr.Value != null)
                        {
                            if (jr.TokenType == JsonToken.String) 
                            {
                                jsonItems.Add(jr.Value.ToString());
                            }

                            if (jr.TokenType == JsonToken.PropertyName)
                            {
                                if (jr.Value.ToString() == "Responses")
                                {
                                    jData.Questions = jsonItems.ToArray();
                                    jsonItems = null;
                                    jsonItems = new List<string>();
                                }
                                else if (jr.Value.ToString() == "Error")
                                {
                                    jData.Responses = jsonItems.ToArray();
                                    jsonItems = null;
                                    jsonItems = new List<string>();
                                }
                                else if (jr.Value.ToString() == "Contacts")
                                {
                                    if (counter == 1) 
                                    {
                                        jData.Error = jsonItems.ToArray();
                                        jsonItems = null;
                                        jsonItems = new List<string>();
                                        counter++;
                                    }
                                }
                            }
                            /* This is required, because there is no other way to tell 
                             * when the contacts section starts */
                            if (counter == 2) 
                            {
                                // add items to contacts
                                jData.Contacts = jsonItems.ToArray();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Could not read file.");
                Console.Error.WriteLine(e.Message);
            }

            return jData;
        }

        public static void WriteData(string outFilename, JData jData) 
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            try 
            {
                using (JsonWriter jWriter = new JsonTextWriter(sw))
                {
                    jWriter.Formatting = Formatting.Indented;
                    jWriter.WriteStartObject ();

                    /* START writing properties to file */

                    // write questions
                    jWriter.WritePropertyName ("Questions");
                    jWriter.WriteStartArray ();
                    foreach (string q in jData.Questions) 
                    {
                        if (String.IsNullOrWhiteSpace(q) != true)
                        {
                            jWriter.WriteValue(q);
                        }
                    }
                    jWriter.WriteEndArray ();
                    // write responses
                    jWriter.WritePropertyName ("Responses");
                    jWriter.WriteStartArray ();
                    foreach (string r in jData.Responses) 
                    {
                        if (String.IsNullOrWhiteSpace(r) != true)
                        {
                            jWriter.WriteValue(r);
                        }
                    }
                    jWriter.WriteEndArray ();
                    // write error messages
                    jWriter.WritePropertyName ("Error");
                    jWriter.WriteStartArray ();
                    foreach (string e in jData.Error) 
                    {
                        if (String.IsNullOrWhiteSpace(e) != true)
                        {
                            jWriter.WriteValue(e);
                        }
                    }
                    jWriter.WriteEndArray ();
                    // write contacts
                    jWriter.WritePropertyName ("Contacts");
                    jWriter.WriteStartArray ();

                    int tempContacts = 0;

                    foreach (string c in jData.Contacts) 
                    {
                        if (String.IsNullOrWhiteSpace(c) != true)
                        {
                      
                
                            if (tempContacts % 2 == 0)
                            {
                                jWriter.WriteStartObject();
                                jWriter.WritePropertyName("text");
                                jWriter.WriteValue(c);
                            }
                            else if (tempContacts % 2 != 0)
                            {
                                jWriter.WritePropertyName("phone");
                                jWriter.WriteValue(c);
                                jWriter.WriteEndObject();
                            }

                            tempContacts++;
                        }
                    }
                    jWriter.WriteEndArray ();

                    /* END writing properties to file */
                    jWriter.WriteEndObject ();
                }

            }
            catch(Exception e) 
            {
                Console.Error.WriteLine (e.Message);
            }

            // write data to output file
            File.WriteAllText(outFilename, sb.ToString());
        }
    }
}       



