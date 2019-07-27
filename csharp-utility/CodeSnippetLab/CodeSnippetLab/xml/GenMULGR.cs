namespace CodeSnippetLab.xml
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    public class MULGRNXML
    {
        public static void GenMULGRNXML()
        {
            #region generate xml to a file

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement root = doc.CreateElement("MGRN");
            doc.AppendChild(root);

            #region lv1 nodes

            // corporation
            XmlNode corporation = doc.CreateElement("Corporation");
            corporation.InnerText = "Corporation";
            root.AppendChild(corporation);

            // GRNNo
            XmlNode grnno = doc.CreateElement("GRNNo");
            grnno.InnerText = "GRNNo";
            root.AppendChild(grnno);

            //GRNDate
            XmlNode grndate = doc.CreateElement("GRNDate");
            grndate.InnerText = "GRNDate";
            root.AppendChild(grndate);

            // Plant
            XmlNode plant = doc.CreateElement("Plant");
            plant.InnerText = "Plant";
            root.AppendChild(plant);

            // PONo
            XmlNode pono = doc.CreateElement("PONo");
            pono.InnerText = "PONo";
            root.AppendChild(pono);

            // VendorCode
            XmlNode vendorCode = doc.CreateElement("VendorCode");
            vendorCode.InnerText = "VendorCode";
            root.AppendChild(vendorCode);

            // VendorName
            XmlNode vendorName = doc.CreateElement("VendorName");
            vendorName.InnerText = "VendorName";
            root.AppendChild(vendorName);

            // Description
            XmlNode description = doc.CreateElement("Description");
            description.InnerText = "Description";
            root.AppendChild(description);

            #endregion

            #region lv2 nodes


            List<XmlNode> grnitems = new List<XmlNode>();
            int size = 36;

            for (int i = 0; i < size; i++)
            {
                XmlNode grnitem = doc.CreateElement("GRNItem");

                // ItemNo
                XmlElement itemNO = doc.CreateElement("ItemNo");
                itemNO.InnerText = string.Format("ItemNo{0}", i + 1);
                grnitem.AppendChild(itemNO);

                // PartsNo
                XmlElement partsNo = doc.CreateElement("PartsNo");
                partsNo.InnerText = string.Format("PartsNo{0}", i + 1);
                grnitem.AppendChild(partsNo);

                // ProductName
                XmlElement productName = doc.CreateElement("ProductName");
                productName.InnerText = string.Format("ProductName{0}", i + 1);
                grnitem.AppendChild(productName);

                // DeliveryQty
                XmlElement deliveryQty = doc.CreateElement("DeliveryQty");
                deliveryQty.InnerText = string.Format("DeliveryQty{0}", i + 1);
                grnitem.AppendChild(deliveryQty);

                // QualifiedQty
                XmlElement qualifiedQty = doc.CreateElement("QualifiedQty");
                qualifiedQty.InnerText = string.Format("QualifiedQty{0}", i + 1);
                grnitem.AppendChild(qualifiedQty);

                // PhysicalQty
                XmlElement physicalQty = doc.CreateElement("PhysicalQty");
                physicalQty.InnerText = string.Format("PhysicalQty{0}", i + 1);
                grnitem.AppendChild(physicalQty);

                // Unit
                XmlElement unit = doc.CreateElement("Unit");
                unit.InnerText = string.Format("Unit{0}", i + 1);
                grnitem.AppendChild(unit);

                // WareHouse
                XmlElement wareHouse = doc.CreateElement("WareHouse");
                wareHouse.InnerText = string.Format("WareHouse{0}", i + 1);
                grnitem.AppendChild(wareHouse);

                grnitems.Add(grnitem);
            }

            foreach (XmlNode item in grnitems)
            {
                root.AppendChild(item);
            }


            #endregion

            string filename = string.Format(@"d:\MULGR-Item-{0}.xml", size);
            doc.Save(filename);
            Console.Write(doc.OuterXml);

            #endregion
        }
    }
}
