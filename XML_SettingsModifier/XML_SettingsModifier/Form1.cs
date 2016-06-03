﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XML_SettingsModifier
{
    public partial class Form1 : Form
    {
        static XmlDocument doc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();

            doc.Load(Application.StartupPath + "\\monkey.xml");

            XmlNodeList aNodes = doc.SelectNodes("/root");
            for (int i = 0; i < aNodes.Count; i++)
            {
                //printChildNodes(aNodes[i]);
                for (int j = 0; j < aNodes[i].ChildNodes.Count; j++)
                {
                    if (aNodes[i].ChildNodes[j].Name == "key")
                    {
                        tb_apikey.Text = aNodes[i].ChildNodes[j].InnerText;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "token")
                    {
                        tb_token.Text = aNodes[i].ChildNodes[j].InnerText;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "datesPrior")
                    {
                        try
                        {
                            dtp_datesprior.Value = DateTime.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "datesAfter")
                    {
                        try
                        {
                            dtp_datesafter.Value = DateTime.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }catch(Exception e)
                        {

                        }
                        
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "surveyName")
                    {
                        tb_surveyName.Text = aNodes[i].ChildNodes[j].InnerText;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "titlesContaining")
                    {
                        tb_titlesContaining.Text = aNodes[i].ChildNodes[j].InnerText;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "RegistryNumber")
                    {
                        try
                        {
                           sp_registrynumber.Value = int.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }
                        catch (Exception e)
                        {


                        }
                        finally
                        {
                            if (aNodes[i].ChildNodes[j].InnerText=="*")
                            {
                                sp_registrynumber.Value = -1;
                            }
                        }
                       
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "initialPage")
                    {
                        try
                        {
                            sp_initialpage.Value = int.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }catch(Exception e)
                        {

                        }
                        
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "endingPage")
                    {
                        try
                        {
                            sp_endingpage.Value = int.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }catch(Exception e)
                        {

                        }
                       
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "responsesPerPage")
                    {
                        try
                        {
                            sp_responsesperpage.Value = int.Parse(aNodes[i].ChildNodes[j].InnerText);
                        }catch(Exception e)
                        {

                        }

                        
                    }
                }
                
                

            }

        }
        //private void printChildNodes(XmlNode node)
        //{
        //    tv_xmlnodes.Nodes.Add(node.Name);
        //    for (int i = 0; i < node.ChildNodes.Count; i++)
        //    {
        //        node.
        //        tv_xmlnodes.Nodes[tv_xmlnodes.Nodes.Count - 1].Nodes.Add(node.ChildNodes[i].Name);
        //        if (node.ChildNodes[i].HasChildNodes)
        //        {
        //            printChildNodes(node.ChildNodes[i]);
        //        }
        //    }
        //}

        private void bt_modify_Click(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\monkey.xml");

            XmlNodeList aNodes = doc.SelectNodes("/root");
            for (int i = 0; i < aNodes.Count; i++)
            {
                for (int j = 0; j < aNodes[i].ChildNodes.Count; j++)
                {
                    if (aNodes[i].ChildNodes[j].Name == "key")
                    {
                        aNodes[i].ChildNodes[j].InnerText = tb_apikey.Text;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "token")
                    {
                        aNodes[i].ChildNodes[j].InnerText = tb_token.Text;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "datesPrior")
                    {

                        aNodes[i].ChildNodes[j].InnerText = dtp_datesprior.Value.ToString();
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "datesAfter")
                    {
                        aNodes[i].ChildNodes[j].InnerText = dtp_datesafter.Value.ToString();
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "surveyName")
                    {
                        aNodes[i].ChildNodes[j].InnerText = tb_surveyName.Text;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "titlesContaining")
                    {
                        aNodes[i].ChildNodes[j].InnerText= tb_titlesContaining.Text;
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "RegistryNumber")
                    {
                        if (sp_registrynumber.Value==-1)
                        {
                            aNodes[i].ChildNodes[j].InnerText = "*";
                        }
                        else
                        {
                            aNodes[i].ChildNodes[j].InnerText = sp_registrynumber.Value.ToString();
                        }
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "initialPage")
                    {
                        aNodes[i].ChildNodes[j].InnerText = sp_initialpage.Value.ToString();
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "endingPage")
                    {
                        aNodes[i].ChildNodes[j].InnerText = sp_endingpage.Value.ToString();
                    }
                    else if (aNodes[i].ChildNodes[j].Name == "responsesPerPage")
                    {
                        aNodes[i].ChildNodes[j].InnerText = sp_responsesperpage.Value.ToString();
                    }
                }
                doc.Save(Application.StartupPath + "\\monkey.xml");
            }
            System.Windows.Forms.MessageBox.Show("XML Modificado con éxito");
        }




        private void tb_apikey_TextChanged(object sender, EventArgs e)
        {
            //tb_apikey.Text = dtp_datesprior.Value.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}