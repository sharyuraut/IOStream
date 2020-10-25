using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace FileIODemo
{
    class XmlSerialDeserial
    {
        public void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\xmlfile.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2015, 12, 31);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream, orderForm);
        }
    }

    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
