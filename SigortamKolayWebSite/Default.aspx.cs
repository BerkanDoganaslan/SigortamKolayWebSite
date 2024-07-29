using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace SigortamKolayWebSite
{
    public partial class _Default : Page
    {
        private List<output> outputs = new List<output>();
        private List<SigortamKolayWebserviceAXA.cityAndTown> cityAndTown = new List<SigortamKolayWebserviceAXA.cityAndTown>();
        private List<SigortamKolayWebserviceAXA.brandAndModel> brandAndModel = new List<SigortamKolayWebserviceAXA.brandAndModel>();

        protected void Page_Load(object sender, EventArgs e)
        {
            fillCityDropdownList();
            fillBrandDropdownList();
        }
        public void getPolicy(Object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
            }
        }        
        private void fillCityDropdownList()
        {
            if (cityAndTown.Count == 0)
            {
                SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient citiesAndTownsRepository = new SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient();
                cityAndTown.AddRange(citiesAndTownsRepository.GetCitiesAndTowns());
                if (!IsPostBack)
                {
                    this.cityCode.Items.Clear();
                    this.plateCityCode.Items.Add("Seçiniz");
                    this.cityCode.Items.Add("Seçiniz");
                    foreach (var item in cityAndTown)
                    {
                        this.cityCode.Items.Add(new ListItem() { Text = item.cityName, Value = item.cityCode.ToString() });                       
                        this.plateCityCode.Items.Add(new ListItem() { Text = item.cityCode.ToString(), Value = item.cityCode.ToString() });
                    }
                }
            }
        }
        private void fillBrandDropdownList()
        {
            if (brandAndModel.Count == 0)
            {
                SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient brandsAndModelsRepository = new SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient();
                brandAndModel.AddRange(brandsAndModelsRepository.GetBrandsAndModels());
                if (!IsPostBack)
                {
                    this.brandCode.Items.Clear();
                    this.brandCode.Items.Add("Seçiniz");
                    foreach (var item in brandAndModel)
                    {
                        this.brandCode.Items.Add(new ListItem() { Text = item.brandName, Value = item.brandCode.ToString() });
                    }
                }
            }
        }
        private void BindGrid()
        {
            try
            {
                //Axa firmasına teklif için giden giriş bilgileri
                SigortamKolayWebserviceAXA.input inputsAXA = new SigortamKolayWebserviceAXA.input();
                SigortamKolayWebserviceAXA.output outputsAXA = new SigortamKolayWebserviceAXA.output();
                SigortamKolayWebserviceAXA.AuthHeader authHeaderAXA = new SigortamKolayWebserviceAXA.AuthHeader();
                SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient policyRepositoryAXA = new SigortamKolayWebserviceAXA.GetPolicyProposalSoapClient();
                authHeaderAXA.Username = "berkan";
                authHeaderAXA.Password = "123456";
                inputsAXA.age = int.Parse(this.age.Text);
                inputsAXA.apartmentNo = int.Parse(this.apartmentNo.Text);
                inputsAXA.brandCode = int.Parse(this.brandCode.SelectedValue);
                inputsAXA.buildingNo = int.Parse(this.buildingNo.Text);
                inputsAXA.cityCode = int.Parse(this.cityCode.SelectedValue);
                inputsAXA.districtName = this.districtName.Text;
                inputsAXA.floorNo = int.Parse(this.floorNo.Text);
                inputsAXA.identityNo = this.identityNo.Text;
                inputsAXA.identityType = int.Parse(this.identityType.SelectedValue);
                inputsAXA.modelCode = int.Parse(this.modelCode.SelectedValue);
                inputsAXA.modelYear = int.Parse(this.modelYear.Text);
                inputsAXA.name = this.name.Text;
                inputsAXA.plateCityCode = int.Parse(this.plateCityCode.SelectedValue);
                inputsAXA.plateNo = this.plateNo.Text;
                inputsAXA.streetName = this.streetName.Text;
                inputsAXA.surName = this.surName.Text;
                inputsAXA.townCode = int.Parse(this.townCode.SelectedValue);
                inputsAXA.villageName = this.villageName.Text;
                inputsAXA.educationStatus = int.Parse(this.educationStatus.SelectedValue);
                inputsAXA.firmName = this.firmName.Text;

                outputsAXA = policyRepositoryAXA.GetProposal(authHeaderAXA, inputsAXA);
                List<outputList> coverlistAxa = new List<outputList>();
                foreach (var item in outputsAXA.outList)
                {
                    coverlistAxa.Add(new outputList
                    {
                        coverAmount = item.coverAmount,
                        coverCode = item.coverCode,
                        coverName = item.coverName,
                        policyNumber = item.policyNumber,
                        premiumAmount = item.premiumAmount
                    });
                }
                outputs.Add(new output
                {
                    clause = outputsAXA.clause,
                    insurancefirmName = outputsAXA.insurancefirmName,
                    policyBeginDate = outputsAXA.policyBeginDate,
                    policyEndDate = outputsAXA.policyEndDate,
                    policyNumber = outputsAXA.policyNumber,
                    productName = outputsAXA.productName,
                    productNo = outputsAXA.productNo,
                    totalPremiumAmount = outputsAXA.totalPremiumAmount,
                    outList = coverlistAxa
                });

                //Ankara firmasına teklif için giden giriş bilgileri
                SigortamKolayWebserviceAnkara.input inputsAnkara = new SigortamKolayWebserviceAnkara.input();
                SigortamKolayWebserviceAnkara.output outputsAnkara = new SigortamKolayWebserviceAnkara.output();
                SigortamKolayWebserviceAnkara.AuthHeader authHeaderAnkara = new SigortamKolayWebserviceAnkara.AuthHeader();
                SigortamKolayWebserviceAnkara.GetPolicyProposalSoapClient policyRepositoryAnkara = new SigortamKolayWebserviceAnkara.GetPolicyProposalSoapClient();
                authHeaderAnkara.Username = "berkan";
                authHeaderAnkara.Password = "123456";
                inputsAnkara.age = int.Parse(this.age.Text);
                inputsAnkara.apartmentNo = int.Parse(this.apartmentNo.Text);
                inputsAnkara.brandCode = int.Parse(this.brandCode.SelectedValue);
                inputsAnkara.buildingNo = int.Parse(this.buildingNo.Text);
                inputsAnkara.cityCode = int.Parse(this.cityCode.SelectedValue);
                inputsAnkara.districtName = this.districtName.Text;
                inputsAnkara.floorNo = int.Parse(this.floorNo.Text);
                inputsAnkara.identityNo = this.identityNo.Text;
                inputsAnkara.identityType = int.Parse(this.identityType.SelectedValue);
                inputsAnkara.modelCode = int.Parse(this.modelCode.SelectedValue);
                inputsAnkara.modelYear = int.Parse(this.modelYear.Text);
                inputsAnkara.name = this.name.Text;
                inputsAnkara.plateCityCode = int.Parse(this.plateCityCode.SelectedValue);
                inputsAnkara.plateNo = this.plateNo.Text;
                inputsAnkara.streetName = this.streetName.Text;
                inputsAnkara.surName = this.surName.Text;
                inputsAnkara.townCode = int.Parse(this.townCode.SelectedValue);
                inputsAnkara.villageName = this.villageName.Text;
                inputsAnkara.educationStatus = int.Parse(this.educationStatus.SelectedValue);
                inputsAnkara.firmName = this.firmName.Text;

                outputsAnkara = policyRepositoryAnkara.GetProposal(authHeaderAnkara, inputsAnkara);
                List<outputList> coverlistAnkara = new List<outputList>();
                foreach (var item in outputsAnkara.outList)
                {
                    coverlistAnkara.Add(new outputList
                    {
                        coverAmount = item.coverAmount,
                        coverCode = item.coverCode,
                        coverName = item.coverName,
                        policyNumber = item.policyNumber,
                        premiumAmount = item.premiumAmount
                    });
                }
                outputs.Add(new output
                {
                    clause = outputsAnkara.clause,
                    insurancefirmName = outputsAnkara.insurancefirmName,
                    policyBeginDate = outputsAnkara.policyBeginDate,
                    policyEndDate = outputsAnkara.policyEndDate,
                    policyNumber = outputsAnkara.policyNumber,
                    productName = outputsAnkara.productName,
                    productNo = outputsAnkara.productNo,
                    totalPremiumAmount = outputsAnkara.totalPremiumAmount,
                    outList = coverlistAnkara
                });

                //Generali firmasına teklif için giden giriş bilgileri
                SigortamKolayWebserviceGenerali.input inputsGenerali = new SigortamKolayWebserviceGenerali.input();
                SigortamKolayWebserviceGenerali.output outputsGenerali = new SigortamKolayWebserviceGenerali.output();
                SigortamKolayWebserviceGenerali.AuthHeader authHeaderGenerali = new SigortamKolayWebserviceGenerali.AuthHeader();
                SigortamKolayWebserviceGenerali.GetPolicyProposalSoapClient policyRepositoryGenerali = new SigortamKolayWebserviceGenerali.GetPolicyProposalSoapClient();
                authHeaderGenerali.Username = "berkan";
                authHeaderGenerali.Password = "123456";
                inputsGenerali.age = int.Parse(this.age.Text);
                inputsGenerali.apartmentNo = int.Parse(this.apartmentNo.Text);
                inputsGenerali.brandCode = int.Parse(this.brandCode.SelectedValue);
                inputsGenerali.buildingNo = int.Parse(this.buildingNo.Text);
                inputsGenerali.cityCode = int.Parse(this.cityCode.SelectedValue);
                inputsGenerali.districtName = this.districtName.Text;
                inputsGenerali.floorNo = int.Parse(this.floorNo.Text);
                inputsGenerali.identityNo = this.identityNo.Text;
                inputsGenerali.identityType = int.Parse(this.identityType.SelectedValue);
                inputsGenerali.modelCode = int.Parse(this.modelCode.SelectedValue);
                inputsGenerali.modelYear = int.Parse(this.modelYear.Text);
                inputsGenerali.name = this.name.Text;
                inputsGenerali.plateCityCode = int.Parse(this.plateCityCode.SelectedValue);
                inputsGenerali.plateNo = this.plateNo.Text;
                inputsGenerali.streetName = this.streetName.Text;
                inputsGenerali.surName = this.surName.Text;
                inputsGenerali.townCode = int.Parse(this.townCode.SelectedValue);
                inputsGenerali.villageName = this.villageName.Text;
                inputsGenerali.educationStatus = int.Parse(this.educationStatus.SelectedValue);
                inputsGenerali.firmName = this.firmName.Text;

                outputsGenerali = policyRepositoryGenerali.GetProposal(authHeaderGenerali, inputsGenerali);
                List<outputList> coverlistGenerali = new List<outputList>();
                foreach (var item in outputsGenerali.outList)
                {
                    coverlistGenerali.Add(new outputList
                    {
                        coverAmount = item.coverAmount,
                        coverCode = item.coverCode,
                        coverName = item.coverName,
                        policyNumber = item.policyNumber,
                        premiumAmount = item.premiumAmount
                    });
                }
                outputs.Add(new output
                {
                    clause = outputsGenerali.clause,
                    insurancefirmName = outputsGenerali.insurancefirmName,
                    policyBeginDate = outputsGenerali.policyBeginDate,
                    policyEndDate = outputsGenerali.policyEndDate,
                    policyNumber = outputsGenerali.policyNumber,
                    productName = outputsGenerali.productName,
                    productNo = outputsGenerali.productNo,
                    totalPremiumAmount = outputsGenerali.totalPremiumAmount,
                    outList = coverlistGenerali
                });

                //Ray firmasına teklif için giden giriş bilgileri
                SigortamKolayWebserviceRay.input inputsRay = new SigortamKolayWebserviceRay.input();
                SigortamKolayWebserviceRay.output outputsRay = new SigortamKolayWebserviceRay.output();
                SigortamKolayWebserviceRay.AuthHeader authHeaderRay = new SigortamKolayWebserviceRay.AuthHeader();
                SigortamKolayWebserviceRay.GetPolicyProposalSoapClient policyRepositoryRay = new SigortamKolayWebserviceRay.GetPolicyProposalSoapClient();
                authHeaderRay.Username = "berkan";
                authHeaderRay.Password = "123456";
                inputsRay.age = int.Parse(this.age.Text);
                inputsRay.apartmentNo = int.Parse(this.apartmentNo.Text);
                inputsRay.brandCode = int.Parse(this.brandCode.SelectedValue);
                inputsRay.buildingNo = int.Parse(this.buildingNo.Text);
                inputsRay.cityCode = int.Parse(this.cityCode.SelectedValue);
                inputsRay.districtName = this.districtName.Text;
                inputsRay.floorNo = int.Parse(this.floorNo.Text);
                inputsRay.identityNo = this.identityNo.Text;
                inputsRay.identityType = int.Parse(this.identityType.SelectedValue);
                inputsRay.modelCode = int.Parse(this.modelCode.SelectedValue);
                inputsRay.modelYear = int.Parse(this.modelYear.Text);
                inputsRay.name = this.name.Text;
                inputsRay.plateCityCode = int.Parse(this.plateCityCode.SelectedValue);
                inputsRay.plateNo = this.plateNo.Text;
                inputsRay.streetName = this.streetName.Text;
                inputsRay.surName = this.surName.Text;
                inputsRay.townCode = int.Parse(this.townCode.SelectedValue);
                inputsRay.villageName = this.villageName.Text;
                inputsRay.educationStatus = int.Parse(this.educationStatus.SelectedValue);
                inputsRay.firmName = this.firmName.Text;

                outputsRay = policyRepositoryRay.GetProposal(authHeaderRay, inputsRay);
                List<outputList> coverlistRay = new List<outputList>();
                foreach (var item in outputsRay.outList)
                {
                    coverlistRay.Add(new outputList
                    {
                        coverAmount = item.coverAmount,
                        coverCode = item.coverCode,
                        coverName = item.coverName,
                        policyNumber = item.policyNumber,
                        premiumAmount = item.premiumAmount
                    });
                }
                outputs.Add(new output
                {
                    clause = outputsRay.clause,
                    insurancefirmName = outputsRay.insurancefirmName,
                    policyBeginDate = outputsRay.policyBeginDate,
                    policyEndDate = outputsRay.policyEndDate,
                    policyNumber = outputsRay.policyNumber,
                    productName = outputsRay.productName,
                    productNo = outputsRay.productNo,
                    totalPremiumAmount = outputsRay.totalPremiumAmount,
                    outList = coverlistRay
                });

                //Sompo Japan firmasına teklif için giden giriş bilgileri
                SigortamKolayWebserviceSompoJapan.input inputsSompoJapan = new SigortamKolayWebserviceSompoJapan.input();
                SigortamKolayWebserviceSompoJapan.output outputsSompoJapan = new SigortamKolayWebserviceSompoJapan.output();
                SigortamKolayWebserviceSompoJapan.AuthHeader authHeaderSompoJapan = new SigortamKolayWebserviceSompoJapan.AuthHeader();
                SigortamKolayWebserviceSompoJapan.GetPolicyProposalSoapClient policyRepositorySompoJapan = new SigortamKolayWebserviceSompoJapan.GetPolicyProposalSoapClient();
                authHeaderSompoJapan.Username = "berkan";
                authHeaderSompoJapan.Password = "123456";
                inputsSompoJapan.age = int.Parse(this.age.Text);
                inputsSompoJapan.apartmentNo = int.Parse(this.apartmentNo.Text);
                inputsSompoJapan.brandCode = int.Parse(this.brandCode.SelectedValue);
                inputsSompoJapan.buildingNo = int.Parse(this.buildingNo.Text);
                inputsSompoJapan.cityCode = int.Parse(this.cityCode.SelectedValue);
                inputsSompoJapan.districtName = this.districtName.Text;
                inputsSompoJapan.floorNo = int.Parse(this.floorNo.Text);
                inputsSompoJapan.identityNo = this.identityNo.Text;
                inputsSompoJapan.identityType = int.Parse(this.identityType.SelectedValue);
                inputsSompoJapan.modelCode = int.Parse(this.modelCode.SelectedValue);
                inputsSompoJapan.modelYear = int.Parse(this.modelYear.Text);
                inputsSompoJapan.name = this.name.Text;
                inputsSompoJapan.plateCityCode = int.Parse(this.plateCityCode.SelectedValue);
                inputsSompoJapan.plateNo = this.plateNo.Text;
                inputsSompoJapan.streetName = this.streetName.Text;
                inputsSompoJapan.surName = this.surName.Text;
                inputsSompoJapan.townCode = int.Parse(this.townCode.SelectedValue);
                inputsSompoJapan.villageName = this.villageName.Text;
                inputsSompoJapan.educationStatus = int.Parse(this.educationStatus.SelectedValue);
                inputsSompoJapan.firmName = this.firmName.Text;

                outputsSompoJapan = policyRepositorySompoJapan.GetProposal(authHeaderSompoJapan, inputsSompoJapan);
                List<outputList> coverlistSompoJapan = new List<outputList>();
                foreach (var item in outputsSompoJapan.outList)
                {
                    coverlistSompoJapan.Add(new outputList
                    {
                        coverAmount = item.coverAmount,
                        coverCode = item.coverCode,
                        coverName = item.coverName,
                        policyNumber = item.policyNumber,
                        premiumAmount = item.premiumAmount
                    });
                }
                outputs.Add(new output
                {
                    clause = outputsSompoJapan.clause,
                    insurancefirmName = outputsSompoJapan.insurancefirmName,
                    policyBeginDate = outputsSompoJapan.policyBeginDate,
                    policyEndDate = outputsSompoJapan.policyEndDate,
                    policyNumber = outputsSompoJapan.policyNumber,
                    productName = outputsSompoJapan.productName,
                    productNo = outputsSompoJapan.productNo,
                    totalPremiumAmount = outputsSompoJapan.totalPremiumAmount,
                    outList = coverlistSompoJapan
                });

                gvPolicy.DataSource = outputs;
                gvPolicy.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string MyNewRow(object policyNo)
        {
            return String.Format(@"</td></tr><tr id ='tr{0}' class='collapsed-row'>
        <td></td><td colspan='100' style='padding:0px; margin:0px;'>", policyNo);
        }
        public string MyNewRowClause(object clause)
        {
            return String.Format(@"</td><tr>
        <td></td><td colspan='100' style='padding:0px; margin:0px;'>{0}<br/></tr>", clause);
        }
        protected void gvPolicy_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string policyNo = gvPolicy.DataKeys[e.Row.RowIndex].Value.ToString();
                var gvCovers = (GridView)e.Row.FindControl("gvCover");

                foreach (var item in outputs)
                {
                    if (item.policyNumber.ToString() == policyNo)
                    {
                        gvCovers.DataSource = item.outList;
                        gvCovers.DataBind();
                    }

                }
            }
        }

        protected void identityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((System.Web.UI.WebControls.ListControl)sender).SelectedValue == "0")
            {
                this.identityNo.Enabled = false;
                this.firmName.Enabled = false;
                this.name.Enabled = false;
                this.surName.Enabled = false;
                this.name.Text = "";
                this.surName.Text = "";
            }
            if (((System.Web.UI.WebControls.ListControl)sender).SelectedValue == "1" || ((System.Web.UI.WebControls.ListControl)sender).SelectedValue == "3" || ((System.Web.UI.WebControls.ListControl)sender).SelectedValue == "4")
            {
                this.firmName.Enabled = false;
                this.firmName.Text = "";
                this.name.Enabled = true;
                this.surName.Enabled = true;
            }
            if (((System.Web.UI.WebControls.ListControl)sender).SelectedValue == "2")
            {
                this.firmName.Enabled = true;
                this.name.Enabled = false;
                this.surName.Enabled = false;
                this.name.Text = "";
                this.surName.Text = "";
            }
        }
            protected void cityCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                townCode.Items.Clear();
                var degerler = from deger in cityAndTown
                               where deger.cityCode.ToString() == ((System.Web.UI.WebControls.ListControl)sender).SelectedValue
                               select deger.towns;
                foreach (var towns in degerler)
                {
                    foreach (var item in towns)
                    {
                        this.townCode.Items.Add(new ListItem() { Text = item.townName, Value = item.townCode.ToString() });
                    }
                }
            }
            catch (Exception)
            {
                throw;

            }

        }
        protected void brandCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                modelCode.Items.Clear();
                var degerler = from deger in brandAndModel
                               where deger.brandCode.ToString() == ((System.Web.UI.WebControls.ListControl)sender).SelectedValue
                               select deger.models;
                foreach (var models in degerler)
                {
                    foreach (var item in models)
                    {
                        this.modelCode.Items.Add(new ListItem() { Text = item.modelName, Value = item.modelCode.ToString() });
                    }
                }
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
