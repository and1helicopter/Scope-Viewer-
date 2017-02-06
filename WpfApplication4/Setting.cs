﻿using System;
using System.Windows;
using System.Xml;

namespace ScopeViewer
{
    public static class Setting
    {
        private static string XmlFileName = "ViewerSettings.xml";

        public static bool ShowDigital;
        public static int PointInLine;
        public static int XMinor;
        public static bool XMinorShow;
        public static int YMinor; 
        public static bool YMinorShow; 
        public static int XMajor; 
        public static bool XMajorShow; 
        public static int YMajor; 
        public static bool YMajorShow; 
        public static bool ShowLegend; 
        public static int SizeLegend;
        public static int Position; 

        static void LoadNameFromXml(string paramName, XmlDocument doc, out int str)
        {
            XmlNodeList xmls = doc.GetElementsByTagName(paramName);
            XmlNode xmlline = xmls[0];
            try
            {
                str = Convert.ToInt32(xmlline.Attributes?["xmlns"].Value);
            }
            catch
            {
                str = 0;
            }          
        }

        private static void LoadNameFromXml(string paramName, XmlDocument doc, out bool str)
        {
            XmlNodeList xmls = doc.GetElementsByTagName(paramName);
            XmlNode xmlline = xmls[0];
            try
            {
                str = Convert.ToBoolean(xmlline.Attributes?["xmlns"].Value);
            }
            catch
            {
                str = false;
            }
        }

        public static void InitSetting()
        {
            var doc = new XmlDocument();
            try
            {
                doc.Load(XmlFileName);
            }
            catch
            {
                MessageBox.Show("Не удалось открыть файл настроек!");
            }

            LoadNameFromXml("ShowDigital", doc, out ShowDigital);
            LoadNameFromXml("PointInLine", doc, out PointInLine);
            LoadNameFromXml("XMinor", doc, out XMinor);
            LoadNameFromXml("XMinorShow", doc, out XMinorShow);
            LoadNameFromXml("YMinor", doc, out YMinor);
            LoadNameFromXml("YMinorShow", doc, out YMinorShow);
            LoadNameFromXml("XMajor", doc, out XMajor);
            LoadNameFromXml("XMajorShow", doc, out XMajorShow);
            LoadNameFromXml("YMajor", doc, out YMajor);
            LoadNameFromXml("YMajorShow", doc, out YMajorShow);
            LoadNameFromXml("ShowLegend", doc, out ShowLegend);
            LoadNameFromXml("SizeLegend", doc, out SizeLegend);
            LoadNameFromXml("Position", doc, out Position);
        }


    }
}
