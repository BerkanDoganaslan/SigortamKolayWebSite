<%@ Page Title="SigortamKolay" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SigortamKolayWebSite._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .collapsed-row { 
            display: none;
            padding: 0px;
            margin: 0px;
        }
        #entryInformtaionTable {
            width: 100%;
        }
        #welcomeTable {
            width: 100%;
        }
        #aboutTable {
            width: 100%;
        }
        #contactTable {
            width: 100%;
        }
        #body {
            background-color:steelblue;
        }
    </style>
    <script type="text/javascript">
        function ToggleGridPanel(btn, row) {
            var current = $('#' + row).css('display');
            if (current == 'none') {
                $('#' + row).show();
                $(btn).removeClass('glyphicon-plus')
                $(btn).addClass('glyphicon-minus')
            } else {
                $('#' + row).hide();
                $(btn).removeClass('glyphicon-minus')
                $(btn).addClass('glyphicon-plus')
            }
            return false;
        }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FirstContent" runat="server">
        <table id="welcomeTable" height="300px" weight="1000px"; background="Images/KaskoSigorta.jpg">

        <tr height="300px" weight="1000px">
            <td style='text-align: left; font-size:xx-large; font-style:italic; vertical-align: middle; color:black';>SigortamKolay'a Hoşgeldiniz</td>
        </tr>
        <tr height="100px" weight="500px">
            <td style='text-align: left; font-size:large; font-style:italic; vertical-align: middle; color:black';>Anında hızlı Kasko Teklifleri için doğru adres</td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="GirisBilgileri" runat="server">
    <table id="entryInformtaionTable" background="Images/MaviArkaPlan.jpg">

        <tr height="30px">
            <td colspan="8" style='text-align: center; font-size:initial ;vertical-align: middle; color:black'>KİMLİK BİLGİLERİ</td>
        </tr>
        <tr height="20px">
            <td width="95px" style='color:black' >Kimlik Tipi:</td>
            <td width="180px" height="20px">
                <asp:DropDownList ID="identityType" runat="server" Height="20px" Width="175px" OnSelectedIndexChanged="identityType_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    <asp:ListItem Value="1">TC Kimlik</asp:ListItem>
                    <asp:ListItem Value="2">Vergi Kimlik</asp:ListItem>
                    <asp:ListItem Value="3">Pasaport</asp:ListItem>
                    <asp:ListItem Value="4">Yabancı Kimlik</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td width="120px" style='color:black'>Kimlik No:</td>
            <td colspan="1" width="180px" height="20px">
                <asp:TextBox ID="identityNo" runat="server" Height="20px" Width="190px" /></td>
            <td width="85px" style='color:black'>&nbsp;Ad:</td>
            <td width="180px">
                <asp:TextBox ID="name" runat="server" Height="20px" Width="190px" /></td>
            <td width="90px" style='color:black'>Soyad:</td>
            <td width="180px">
                <asp:TextBox ID="surName" runat="server" Height="20px" Width="200px" /></td>
        <tr>
            <td width="95px" style='color:black'>Firma Adı:</td>    
            <td>
                <asp:TextBox ID="firmName" runat="server" Height="20px" Width="175px" /></td>
            <td colspan="6"></td>
        </tr>
        <tr>
            <td colspan="8" height="10px"></td>
        </tr>
        <tr height="30px">
            <td colspan="8" style='text-align: center; font-size:initial; vertical-align: middle; color:black '>DİĞER BİLGİLER</td>
        </tr>
        <tr height="20px">
            <td width="95px" style='color:black'>Yaş:</td>
            <td>
                <asp:TextBox ID="age" runat="server" Height="20px" Width="175px" /></td>
            <td width="120px" height="20px" style='color:black'>Öğrenim Durumu:</td>
            <td>
                <asp:DropDownList ID="educationStatus" runat="server" Height="20px" Width="190px" OnSelectedIndexChanged="identityType_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    <asp:ListItem Value="1">İlkokul</asp:ListItem>
                    <asp:ListItem Value="2">Ortaokul</asp:ListItem>
                    <asp:ListItem Value="3">Lise</asp:ListItem>
                    <asp:ListItem Value="4">Ön Lisans</asp:ListItem>
                    <asp:ListItem Value="5">Lisans</asp:ListItem>
                    <asp:ListItem Value="6">Yüksek Lisans</asp:ListItem>
                    <asp:ListItem Value="7">Yok</asp:ListItem>
                </asp:DropDownList>
            <td colspan="4"></td>
        <tr>
            <td colspan="8" height="10px"></td>
        </tr>
        <tr height="30px">
            <td colspan="8" style='text-align: center; font-size:initial; vertical-align: middle; color:black'>ARAÇ BİLGİLERİ</td>
        </tr>
        <tr height="20px">
            <td width="95px" style='color:black'>İl Plaka Kodu:</td>
            <td>
                <asp:DropDownList ID="plateCityCode" runat="server" Height="20px" Width="175px" /></td>
            <td width="120px" style='color:black'>Plaka No:</td>
            <td colspan="1" width="140px" height="20px">
                <asp:TextBox ID="plateNo" runat="server" Height="20px" Width="190px" /></td>
            <td width="85px" style='color:black'>Marka:</td>
            <td>
                <asp:DropDownList ID="brandCode" runat="server" Height="20px" Width="190px" AutoPostBack="True" OnSelectedIndexChanged="brandCode_SelectedIndexChanged" /></td>
            <td width="90px" style='color:black'>Model:</td>
            <td>
                <asp:DropDownList ID="modelCode" runat="server" Height="20px" Width="200px" /></td>
            <tr height="20px">
                <td width="95px" style='color:black'>Model Yılı:</td>
                <td>
                    <asp:TextBox ID="modelYear" runat="server" Height="20px" Width="175px" /></td>
                <td colspan="6"></td>
            </tr>
            <tr>
                <td colspan="8" height="10px"></td>
            </tr>
            <tr height="30px">
                <td colspan="8" style='text-align: center; font-size:initial; vertical-align: middle; color:black'>ADRES BİLGİLERİ</td>
            </tr>
        </tr>
        <tr height="20px">
            <td width="95px" height="20px" style='color:black'>Şehir:</td>
            <td>
                <asp:DropDownList ID="cityCode" runat="server" OnSelectedIndexChanged="cityCode_SelectedIndexChanged" Height="20px" Width="175px" AutoPostBack="True" /></td>
            <td width="120px" style='color:black'>İlçe:</td>
            <td>
                <asp:DropDownList ID="townCode" runat="server" Height="20px" Width="190px" /></td>
            <td width="85px" style='color:black'>Mahalle Adı:</td>
            <td>
                <asp:TextBox ID="districtName" runat="server" Height="20px" Width="190px" /></td>
            <td width="90px" style='color:black'>Köy/Kasaba:</td>
            <td>
                <asp:TextBox ID="villageName" runat="server" Height="20px" Width="200px" /></td>
        </tr>
        <tr height="20px">
            <td width="95px" height="20px" style='color:black'>Sokak Adı:</td>
            <td>
                <asp:TextBox ID="streetName" runat="server" Height="20px" Width="175px" /></td>
            <td width="120px" style='color:black'>Bina No:</td>
            <td>
                <asp:TextBox ID="buildingNo" runat="server" Height="20px" Width="190px" /></td>
            <td width="85px" style='color:black'>Kat No:</td>
            <td>
                <asp:TextBox ID="floorNo" runat="server" Height="20px" Width="190px" /></td>
            <td width="90px" style='color:black'>Daire No:</td>
            <td>
                <asp:TextBox ID="apartmentNo" runat="server" Height="20px" Width="200px" /></td>
        </tr>
        <tr>
            <td colspan="8" height="30px"></td>
        </tr>
        <tr>
            <td colspan="8" style='text-align: center; vertical-align: middle;'>
                <asp:Button ID="btnGetPolicy" OnClick="getPolicy" Text="Teklif Al" runat="server" Height="30px" Width="100px" BorderColor="darkcyan" BorderStyle="Groove" BorderWidth="2px" ForeColor="Black"/></td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvPolicy" runat="server" background="Images/MaviArkaPlan.jpg"
        DataKeyNames="policyNumber"
        Width="100%"
        GridLines="None"
        AutoGenerateColumns="false"
        OnRowDataBound="gvPolicy_RowDataBound">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <button class="btn btn-default glyphicon glyphicon-plus" onclick="return ToggleGridPanel(this, 'tr<%# Eval("policyNumber") %>')" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="insurancefirmName" HeaderText="Sigorta Şirketi" />
            <asp:BoundField DataField="policyNumber" HeaderText="Poliçe Numarası" />
            <asp:BoundField DataField="productNo" HeaderText="Ürün Numarası" />
            <asp:BoundField DataField="productName" HeaderText="Ürün Adı" />
            <asp:BoundField DataField="totalPremiumAmount" HeaderText="Toplam Prim Tutarı" />
            <asp:BoundField DataField="policyBeginDate" HeaderText="Poliçe Başlangıç Tarihi" />
            <asp:TemplateField HeaderText="Poliçe Bitiş Tarihi">
                <ItemTemplate>
                    <%#Eval("policyEndDate") %>
                    <%#MyNewRow(Eval("policyNumber")) %>
                    <asp:GridView ID="gvCover" runat="server"
                        Width="100%"
                        GridLines="None"
                        AutoGenerateColumns="false"
                        DataKeyNames="policyNumber">
                        <Columns>
                            <asp:BoundField DataField="coverCode" HeaderText="Teminat Kodu" />
                            <asp:BoundField DataField="coverName" HeaderText="Teminat Adı" />
                            <asp:BoundField DataField="coverAmount" HeaderText="Teminat Tutarı" />
                            <asp:BoundField DataField="premiumAmount" HeaderText="Prim Tutarı" />
                        </Columns>
                    </asp:GridView>
                    <%#MyNewRowClause(Eval("clause")) %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </table>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="LastContent" runat="server">
    <table id="aboutTable" height="300px" weight="1000px"; background="Images/MaviArkaPlan.jpg">
    <tr height="20px" weight="500px">
        <td style='text-align: center; font-size:x-large; font-style:initial; vertical-align: middle; color:black';;>Hakkımızda</td>
        <td style='text-align: center; font-size:x-large; font-style:initial; vertical-align: middle; color:black';>İletişim</td>
    </tr>
    <tr height="100px" weight="500px">
        <td style='text-align: center; font-size:medium; font-style:italic; vertical-align: middle; color:black';>VİZYONUMUZ:<br />Müşterilerimize her zaman en iyi ve en hızlı hizmeti sunmak
            <br />MİSYONUMUZ:<br />Amacına uygun ve kolay ulaşılabilir sigorta teklifleri sunan ve tercih edilen ilk şirket olmak<br />İLKELERİMİZ:<br />
            Müşterilerimize en kaliteli hizmetleri sunmak için;<br />- Hedeflerimizi yüksek tutar ve bunlardan ders çıkartırız<br />- Her zaman hızlı hareket ederiz<br />
            - Ahlaki değerlere uygun davranırız</td>
        <td style='text-align: center; font-size:medium; font-style:italic; vertical-align: middle; color:black';>GENEL MERKEZ:<br />Merkez mah. Üsküdar cad. Yardımcı sokak No:3 D:12
            <br />Çekmeköy/İSTANBUL<br />TEL:<br />0539 387 66 20<br />E-POSTA:<br />berkan.doganaslan34@gmail.com<br />berkan.doganaslan2018@pru.edu.tr</td>
    </tr>
    </table>  
</asp:Content>

