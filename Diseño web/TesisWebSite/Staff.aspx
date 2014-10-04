<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Staff.aspx.cs" Inherits="Staff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 31px;
        }
        .style3
        {
            width: 173px;
        }
        .style4
        {
            height: 19px;
            width: 173px;
        }
        .style5
        {
            width: 173px;
            height: 34px;
        }
        .style6
        {
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style5">
                <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Cuerpo Médico"></asp:Label>
            </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/foto-medico.jpg" />
            </td>
            <td class="style2">
                <div class="ind">
                        
                        	                            
                            <div >
                            									
                                    <h2 class="style2">Dr Roque Maffrand:</h2>
            <p style="text-align: justify; "><span class="style2"> 
•	Profesor en la Cátedra de Oftalmología en UOL Argentina.<br />
•   Médico Oftalmólogo.<br />
•   Director de la Clínica Oftalmológicas SATO.<br /></span></p>
                                            
                            </div>
                            </div>
                
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/foto-medico.jpg" />
            </td>
            <td>
                &nbsp;
                <div class="ind">
                        
                        	                            
                            <div >
                            									
                                    <h2 class="style2">Dra Alicia Ramirez:</h2>
            <p style="text-align: justify; "><span class="style2"> 
•	Presidente del Comité de Contralor de Anestesiología.<br />
•   Médica Oftalmóloga.<br />
•   Gerente General de la Clínica Oftalmológicas SATO.<br /></span></p>
                                            
                            </div>
                            </div>
             </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Imagenes/foto-medico.jpg" />
            </td>
            <td>
                &nbsp;
                <div class="ind">
                        
                        	                            
                            <div >
                            									
                                    <h2 class="style2">Dra Carola Maffrand:</h2>
            <p style="text-align: justify; "><span class="style2"> 
•	Jefa de Residentes de Oftalmología de la Universidad Nacional de Cordoba, Facultad de Ciencias Médicas.<br />
•   Médica Oftalmóloga.<br />
•   Directora de la Clínica Oftalmológicas SATO.<br /></span></p>
                                            
                            </div>
                            </div>
            </td>
        </tr>
    </table>
</asp:Content>

