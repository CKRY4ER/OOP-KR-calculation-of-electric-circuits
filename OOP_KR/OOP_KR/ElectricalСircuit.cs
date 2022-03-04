using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OOP_KR
{
    [Serializable, XmlInclude(typeof(Node)), XmlInclude(typeof(CollectionBranches)), XmlInclude(typeof(CollectionElements)), XmlInclude(typeof(Branche)), XmlInclude(typeof(Resister)), XmlInclude(typeof(Lamp)), XmlInclude(typeof(Key)), XmlInclude(typeof(CCS))]
    public class ElectricalСircuit
    {
        public CollectionBranches branches = new CollectionBranches();
        private Node fNode=new Node("1");
        private Node sNode= new Node("2");
        private Node tNode=new Node("3");
        public Node FNode { get=>fNode; set=>fNode=value; }
        public Node SNode { get=>sNode; set=>sNode=value; }
        public Node TNode { get=>tNode; set=>tNode=value; }
        public ElectricalСircuit() 
        {
        }
        public ElectricalСircuit(CollectionBranches br) { }
        public static ElectricalСircuit RestoreDocuments(string nameFile)
        {
            FileStream reader = new FileStream(nameFile, FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer deserializer = new XmlSerializer(typeof(ElectricalСircuit));
            ElectricalСircuit documents;
            try
            {
                documents = (ElectricalСircuit)deserializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                documents = new ElectricalСircuit(new CollectionBranches());
            }
            reader.Close();
            return documents;
        }

        public static void SaveDocuments(ElectricalСircuit electricalСircuit, string nameFile)
        {
            StreamWriter writer = new StreamWriter(nameFile);
            XmlSerializer serializer = new XmlSerializer(typeof(ElectricalСircuit));
            serializer.Serialize(writer, electricalСircuit);
            writer.Close();
        }
        public void СountPotencial()
        {

        }
        public void DeleteCircuit()
        {
            branches.DeleteListBranch();
            
        }
    }
}