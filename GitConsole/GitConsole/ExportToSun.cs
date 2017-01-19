using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GitConsole
{
    class ExportToSun
    {
        string UserName { get; set; }
        string BusinessUnit { get; set; }
        string PHPurchaseTransactionType { get; set; }
        string PHSecondReference { get; set; }
        string PHSupplierCode { get; set; }
        string PHComment { get; set; }
        string PHMiscellaneousDate1 { get; set; }
        string PHMiscellaneousDate2 { get; set; }
        string PHMiscellaneousDescription1 { get; set; }
        string PHMiscellaneousDescription2 { get; set; }
        string PHMiscellaneousInput1 { get; set; }
        string PHMiscellaneousInput2 { get; set; }
        string PHMiscellaneousReference1 { get; set; }
        string PHMiscellaneousReference2 { get; set; }
        string PLLocationId { get; set; }
        string PLItemCode { get; set; }
        string PLDescription { get; set; }
        string PLUnitOfPurchase { get; set; }
        string PLCurrencyCode { get; set; }
        string PLAccountCode { get; set; }
        string PLAssetCode { get; set; }
        string PLTransactionPeriod { get; set; }
        string PLOrderDate { get; set; }
        string PLPaymentTermsGroupCode { get; set; }
        string PLBuyer { get; set; }
        string PLPurchaseRequisitionDate { get; set; }
        string PLPurchaseRequisitionDetails { get; set; }
        string PLPurchaseRequisitionEmployee { get; set; }
        string PLPurchaseRequisitionTransRef { get; set; }
        string PLMiscellaneousDescription1 { get; set; }
        string PLMiscellaneousDescription2 { get; set; }
        string PLMiscellaneousReference1 { get; set; }
        string PLMiscellaneousReference2 { get; set; }
        string PLMiscellaneousInput1 { get; set; }
        string PLMiscellaneousInput2 { get; set; }
        string PLMiscellaneousDate1 { get; set; }
        string PLMiscellaneousDate2 { get; set; }
        string PAVPolCatAnalysis_AnlCatId01 { get; set; }
        string PAVPolCatAnalysis_AnlCode01 { get; set; }
        string PAVPolCatAnalysis_AnlCatId02 { get; set; }
        string PAVPolCatAnalysis_AnlCode02 { get; set; }
        string PAVPolCatAnalysis_AnlCatId03 { get; set; }
        string PAVPolCatAnalysis_AnlCode03 { get; set; }
        string PAVPolCatAnalysis_AnlCatId04 { get; set; }
        string PAVPolCatAnalysis_AnlCode04 { get; set; }
        string PAVPolCatAnalysis_AnlCatId05 { get; set; }
        string PAVPolCatAnalysis_AnlCode05 { get; set; }
        string PAVPolCatAnalysis_AnlCatId06 { get; set; }
        string PAVPolCatAnalysis_AnlCode06 { get; set; }
        string PAVPolCatAnalysis_AnlCatId07 { get; set; }
        string PAVPolCatAnalysis_AnlCode07 { get; set; }
        string PAVPolCatAnalysis_AnlCatId08 { get; set; }
        string PAVPolCatAnalysis_AnlCode08 { get; set; }
        string PAVPolCatAnalysis_AnlCatId09 { get; set; }
        string PAVPolCatAnalysis_AnlCode09 { get; set; }
        string PAVPolCatAnalysis_AnlCatId10 { get; set; }
        string PAVPolCatAnalysis_AnlCode10 { get; set; }
        string PVVPolVlabEntry_Val01b { get; set; }
        string PVVPolVlabEntry_VlabId01b { get; set; }
        string PVVPolVlabEntry_Val01t { get; set; }
        string PVVPolVlabEntry_VlabId01t { get; set; }
        string PVVPolVlabEntry_Val02b { get; set; }
        string PVVPolVlabEntry_VlabId02b { get; set; }
        string PVVPolVlabEntry_Val02t { get; set; }
        string PVVPolVlabEntry_VlabId02t { get; set; }
        string PVVPolVlabEntry_Val03b { get; set; }
        string PVVPolVlabEntry_VlabId03b { get; set; }
        string PVVPolVlabEntry_Val03t { get; set; }
        string PVVPolVlabEntry_VlabId03t { get; set; }
        string PVVPolVlabEntry_Val04b { get; set; }
        string PVVPolVlabEntry_VlabId04b { get; set; }
        string PVVPolVlabEntry_Val04t { get; set; }
        string PVVPolVlabEntry_VlabId04t { get; set; }
        string PVVPolVlabEntry_Val05b { get; set; }
        string PVVPolVlabEntry_VlabId05b { get; set; }
        string PVVPolVlabEntry_Val05t { get; set; }
        string PVVPolVlabEntry_VlabId05t { get; set; }
        string PVVPolVlabEntry_Val06b { get; set; }
        string PVVPolVlabEntry_VlabId06b { get; set; }
        string PVVPolVlabEntry_Val06t { get; set; }
        string PVVPolVlabEntry_VlabId06t { get; set; }
        string PVVPolVlabEntry_Val07b { get; set; }
        string PVVPolVlabEntry_VlabId07b { get; set; }
        string PVVPolVlabEntry_Val07t { get; set; }
        string PVVPolVlabEntry_VlabId07t { get; set; }
        string PVVPolVlabEntry_Val08b { get; set; }
        string PVVPolVlabEntry_VlabId08b { get; set; }
        string PVVPolVlabEntry_Val08t { get; set; }
        string PVVPolVlabEntry_VlabId08t { get; set; }
        string PVVPolVlabEntry_Val09b { get; set; }
        string PVVPolVlabEntry_VlabId09b { get; set; }
        string PVVPolVlabEntry_Val09t { get; set; }
        string PVVPolVlabEntry_VlabId09t { get; set; }
        string PVVPolVlabEntry_Val10b { get; set; }
        string PVVPolVlabEntry_VlabId10b { get; set; }
        string PVVPolVlabEntry_Val10t { get; set; }
        string PVVPolVlabEntry_VlabId10t { get; set; }

        public void CreateXml()
        {
            XmlTextWriter writer = new XmlTextWriter("PurchaseOrder.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("SSC");
            createNode(
                writer,
                UserName,
                BusinessUnit,
                PHPurchaseTransactionType,
                PHSecondReference,
                PHSupplierCode,
                PHComment,
                PHMiscellaneousDate1,
                PHMiscellaneousDate2,
                PHMiscellaneousDescription1,
                PHMiscellaneousDescription2,
                PHMiscellaneousInput1,
                PHMiscellaneousInput2,
                PHMiscellaneousReference1,
                PHMiscellaneousReference2,
                PLLocationId,
                PLItemCode,
                PLDescription,
                PLUnitOfPurchase,
                PLCurrencyCode,
                PLAccountCode,
                PLAssetCode,
                PLTransactionPeriod,
                PLOrderDate,
                PLPaymentTermsGroupCode,
                PLBuyer,
                PLPurchaseRequisitionDate,
                PLPurchaseRequisitionDetails,
                PLPurchaseRequisitionEmployee,
                PLPurchaseRequisitionTransRef,
                PLMiscellaneousDescription1,
                PLMiscellaneousDescription2,
                PLMiscellaneousReference1,
                PLMiscellaneousReference2,
                PLMiscellaneousInput1,
                PLMiscellaneousInput2,
                PLMiscellaneousDate1,
                PLMiscellaneousDate2,
                PAVPolCatAnalysis_AnlCatId01,
                PAVPolCatAnalysis_AnlCode01,
                PAVPolCatAnalysis_AnlCatId02,
                PAVPolCatAnalysis_AnlCode02,
                PAVPolCatAnalysis_AnlCatId03,
                PAVPolCatAnalysis_AnlCode03,
                PAVPolCatAnalysis_AnlCatId04,
                PAVPolCatAnalysis_AnlCode04,
                PAVPolCatAnalysis_AnlCatId05,
                PAVPolCatAnalysis_AnlCode05,
                PAVPolCatAnalysis_AnlCatId06,
                PAVPolCatAnalysis_AnlCode06,
                PAVPolCatAnalysis_AnlCatId07,
                PAVPolCatAnalysis_AnlCode07,
                PAVPolCatAnalysis_AnlCatId08,
                PAVPolCatAnalysis_AnlCode08,
                PAVPolCatAnalysis_AnlCatId09,
                PAVPolCatAnalysis_AnlCode09,
                PAVPolCatAnalysis_AnlCatId10,
                PAVPolCatAnalysis_AnlCode10,
                PVVPolVlabEntry_Val01b,
                PVVPolVlabEntry_VlabId01b,
                PVVPolVlabEntry_Val01t,
                PVVPolVlabEntry_VlabId01t,
                PVVPolVlabEntry_Val02b,
                PVVPolVlabEntry_VlabId02b,
                PVVPolVlabEntry_Val02t,
                PVVPolVlabEntry_VlabId02t,
                PVVPolVlabEntry_Val03b,
                PVVPolVlabEntry_VlabId03b,
                PVVPolVlabEntry_Val03t,
                PVVPolVlabEntry_VlabId03t,
                PVVPolVlabEntry_Val04b,
                PVVPolVlabEntry_VlabId04b,
                PVVPolVlabEntry_Val04t,
                PVVPolVlabEntry_VlabId04t,
                PVVPolVlabEntry_Val05b,
                PVVPolVlabEntry_VlabId05b,
                PVVPolVlabEntry_Val05t,
                PVVPolVlabEntry_VlabId05t,
                PVVPolVlabEntry_Val06b,
                PVVPolVlabEntry_VlabId06b,
                PVVPolVlabEntry_Val06t,
                PVVPolVlabEntry_VlabId06t,
                PVVPolVlabEntry_Val07b,
                PVVPolVlabEntry_VlabId07b,
                PVVPolVlabEntry_Val07t,
                PVVPolVlabEntry_VlabId07t,
                PVVPolVlabEntry_Val08b,
                PVVPolVlabEntry_VlabId08b,
                PVVPolVlabEntry_Val08t,
                PVVPolVlabEntry_VlabId08t,
                PVVPolVlabEntry_Val09b,
                PVVPolVlabEntry_VlabId09b,
                PVVPolVlabEntry_Val09t,
                PVVPolVlabEntry_VlabId09t,
                PVVPolVlabEntry_Val10b,
                PVVPolVlabEntry_VlabId10b,
                PVVPolVlabEntry_Val10t,
                PVVPolVlabEntry_VlabId10t
                );

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            //MessageBox.Show("XML File created ! ");
        }

        private void createNode(
            XmlTextWriter writer,
            string userName,
            string businessUnit,
            string phPurchaseTransactionType,
            string phSecondReference,
            string phSupplierCode,
            string phComment,
            string phMiscellaneousDate1,
            string phMiscellaneousDate2,
            string phMiscellaneousDescription1,
            string phMiscellaneousDescription2,
            string phMiscellaneousInput1,
            string phMiscellaneousInput2,
            string phMiscellaneousReference1,
            string phMiscellaneousReference2,
            string plLocationId,
            string plItemCode,
            string plDescription,
            string plUnitOfPurchase,
            string plCurrencyCode,
            string plAccountCode,
            string plAssetCode,
            string plTransactionPeriod,
            string plOrderDate,
            string plPaymentTermsGroupCode,
            string plBuyer,
            string plPurchaseRequisitionDate,
            string plPurchaseRequisitionDetails,
            string plPurchaseRequisitionEmployee,
            string plPurchaseRequisitionTransRef,
            string plMiscellaneousDescription1,
            string plMiscellaneousDescription2,
            string plMiscellaneousReference1,
            string plMiscellaneousReference2,
            string plMiscellaneousInput1,
            string plMiscellaneousInput2,
            string plMiscellaneousDate1,
            string plMiscellaneousDate2,
            string paVPolCatAnalysis_AnlCatId01,
            string paVPolCatAnalysis_AnlCode01,
            string paVPolCatAnalysis_AnlCatId02,
            string paVPolCatAnalysis_AnlCode02,
            string paVPolCatAnalysis_AnlCatId03,
            string paVPolCatAnalysis_AnlCode03,
            string paVPolCatAnalysis_AnlCatId04,
            string paVPolCatAnalysis_AnlCode04,
            string paVPolCatAnalysis_AnlCatId05,
            string paVPolCatAnalysis_AnlCode05,
            string paVPolCatAnalysis_AnlCatId06,
            string paVPolCatAnalysis_AnlCode06,
            string paVPolCatAnalysis_AnlCatId07,
            string paVPolCatAnalysis_AnlCode07,
            string paVPolCatAnalysis_AnlCatId08,
            string paVPolCatAnalysis_AnlCode08,
            string paVPolCatAnalysis_AnlCatId09,
            string paVPolCatAnalysis_AnlCode09,
            string paVPolCatAnalysis_AnlCatId10,
            string paVPolCatAnalysis_AnlCode10,
            string pvVPolVlabEntry_Val01b,
            string pvVPolVlabEntry_VlabId01b,
            string pvVPolVlabEntry_Val01t,
            string pvVPolVlabEntry_VlabId01t,
            string pvVPolVlabEntry_Val02b,
            string pvVPolVlabEntry_VlabId02b,
            string pvVPolVlabEntry_Val02t,
            string pvVPolVlabEntry_VlabId02t,
            string pvVPolVlabEntry_Val03b,
            string pvVPolVlabEntry_VlabId03b,
            string pvVPolVlabEntry_Val03t,
            string pvVPolVlabEntry_VlabId03t,
            string pvVPolVlabEntry_Val04b,
            string pvVPolVlabEntry_VlabId04b,
            string pvVPolVlabEntry_Val04t,
            string pvVPolVlabEntry_VlabId04t,
            string pvVPolVlabEntry_Val05b,
            string pvVPolVlabEntry_VlabId05b,
            string pvVPolVlabEntry_Val05t,
            string pvVPolVlabEntry_VlabId05t,
            string pvVPolVlabEntry_Val06b,
            string pvVPolVlabEntry_VlabId06b,
            string pvVPolVlabEntry_Val06t,
            string pvVPolVlabEntry_VlabId06t,
            string pvVPolVlabEntry_Val07b,
            string pvVPolVlabEntry_VlabId07b,
            string pvVPolVlabEntry_Val07t,
            string pvVPolVlabEntry_VlabId07t,
            string pvVPolVlabEntry_Val08b,
            string pvVPolVlabEntry_VlabId08b,
            string pvVPolVlabEntry_Val08t,
            string pvVPolVlabEntry_VlabId08t,
            string pvVPolVlabEntry_Val09b,
            string pvVPolVlabEntry_VlabId09b,
            string pvVPolVlabEntry_Val09t,
            string pvVPolVlabEntry_VlabId09t,
            string pvVPolVlabEntry_Val10b,
            string pvVPolVlabEntry_VlabId10b,
            string pvVPolVlabEntry_Val10t,
            string pvVPolVlabEntry_VlabId10t
            )
        {
            #region SSC
            writer.WriteStartElement("User");
            writer.WriteStartElement("Name");
            writer.WriteString(userName);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("SunSystemsContext");
            writer.WriteStartElement("BusinessUnit");
            writer.WriteString(businessUnit);
            writer.WriteEndElement();
            writer.WriteEndElement();

            #region Payload
            writer.WriteStartElement("Payload");

            #region PurchaseOrder
            writer.WriteStartElement("PurchaseOrder");

            writer.WriteStartElement("PurchaseTransactionType");
            writer.WriteString(phPurchaseTransactionType);
            writer.WriteEndElement();

            writer.WriteStartElement("SecondReference");
            writer.WriteString(phSecondReference);
            writer.WriteEndElement();

            writer.WriteStartElement("SupplierCode");
            writer.WriteString(phSupplierCode);
            writer.WriteEndElement();

            writer.WriteStartElement("Comment");
            writer.WriteString(phComment);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDate1");
            writer.WriteString(phMiscellaneousDate1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDate2");
            writer.WriteString(phMiscellaneousDate2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDescription1");
            writer.WriteString(phMiscellaneousDescription1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDescription2");
            writer.WriteString(phMiscellaneousDescription2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousInput1");
            writer.WriteString(phMiscellaneousInput1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousInput2");
            writer.WriteString(phMiscellaneousInput2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousReference1");
            writer.WriteString(phMiscellaneousReference1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousReference2");
            writer.WriteString(phMiscellaneousReference2);
            writer.WriteEndElement();

            #region PurchaseOrderLine
            writer.WriteStartElement("PurchaseOrderLine");

            writer.WriteStartElement("LocationId");
            writer.WriteString(plLocationId);
            writer.WriteEndElement();

            writer.WriteStartElement("ItemCode");
            writer.WriteString(plItemCode);
            writer.WriteEndElement();

            writer.WriteStartElement("Description");
            writer.WriteString(plDescription);
            writer.WriteEndElement();

            writer.WriteStartElement("UnitOfPurchase");
            writer.WriteString(plUnitOfPurchase);
            writer.WriteEndElement();

            writer.WriteStartElement("CurrencyCode");
            writer.WriteString(plCurrencyCode);
            writer.WriteEndElement();

            writer.WriteStartElement("AccountCode");
            writer.WriteString(plAccountCode);
            writer.WriteEndElement();

            writer.WriteStartElement("AssetCode");
            writer.WriteString(plAssetCode);
            writer.WriteEndElement();

            writer.WriteStartElement("TransactionPeriod");
            writer.WriteString(plTransactionPeriod);
            writer.WriteEndElement();

            writer.WriteStartElement("OrderDate");
            writer.WriteString(plOrderDate);
            writer.WriteEndElement();

            writer.WriteStartElement("PaymentTermsGroupCode");
            writer.WriteString(plPaymentTermsGroupCode);
            writer.WriteEndElement();

            writer.WriteStartElement("Buyer");
            writer.WriteString(plBuyer);
            writer.WriteEndElement();

            writer.WriteStartElement("PurchaseRequisitionDate");
            writer.WriteString(plPurchaseRequisitionDate);
            writer.WriteEndElement();

            writer.WriteStartElement("PurchaseRequisitionDetails");
            writer.WriteString(plPurchaseRequisitionDetails);
            writer.WriteEndElement();

            writer.WriteStartElement("PurchaseRequisitionEmployee");
            writer.WriteString(plPurchaseRequisitionEmployee);
            writer.WriteEndElement();

            writer.WriteStartElement("PurchaseRequisitionTransRef");
            writer.WriteString(plPurchaseRequisitionTransRef);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDescription1");
            writer.WriteString(plMiscellaneousDescription1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDescription2");
            writer.WriteString(plMiscellaneousDescription2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousReference1");
            writer.WriteString(plMiscellaneousReference1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousReference2");
            writer.WriteString(plMiscellaneousReference2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousInput1");
            writer.WriteString(plMiscellaneousInput1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousInput2");
            writer.WriteString(plMiscellaneousInput2);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDate1");
            writer.WriteString(plMiscellaneousDate1);
            writer.WriteEndElement();

            writer.WriteStartElement("MiscellaneousDate2");
            writer.WriteString(plMiscellaneousDate2);
            writer.WriteEndElement();

            #region AnalysisQuantity
            writer.WriteStartElement("AnalysisQuantity");

            writer.WriteStartElement("Analysis1");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId01);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode01);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis2");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId02);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode02);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis3");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId03);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode03);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis4");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId04);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode04);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis5");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId05);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode05);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis6");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId06);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode06);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis7");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId07);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode07);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis8");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId08);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode08);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis9");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId09);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode09);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Analysis10");
            writer.WriteStartElement("VPolCatAnalysis_AnlCatId");
            writer.WriteString(paVPolCatAnalysis_AnlCatId10);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolCatAnalysis_AnlCode");
            writer.WriteString(paVPolCatAnalysis_AnlCode10);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteEndElement();
            #endregion

            #region VLAB
            writer.WriteStartElement("VLAB1");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val01b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId01b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val01t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId01t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB2");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val02b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId02b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val02t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId02t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB3");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val03b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId03b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val03t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId03t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB4");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val04b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId04b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val04t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId04t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB5");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val05b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId05b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val05t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId05t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB6");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val06b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId06b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val06t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId06t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB7");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val07b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId07b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val07t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId07t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB8");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val08b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId08b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val08t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId08t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB9");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val09b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId09b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val09t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId09t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("VLAB10");
            writer.WriteStartElement("Base");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val10b);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId10b);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteStartElement("Trans");
            writer.WriteStartElement("VPolVlabEntry_Val");
            writer.WriteString(pvVPolVlabEntry_Val10t);
            writer.WriteEndElement();
            writer.WriteStartElement("VPolVlabEntry_VlabId");
            writer.WriteString(pvVPolVlabEntry_VlabId10t);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();

            #endregion

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion
        }
    }
}
