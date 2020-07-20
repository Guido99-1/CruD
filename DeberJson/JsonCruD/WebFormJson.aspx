<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormJson.aspx.cs" Inherits="JsonCruD.WebFormJson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
            color: #3399FF;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style3 {
            text-align: center;
            color: #990000;
        }
        .auto-style4 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%">
                <tr>
                    <td colspan="2" class="auto-style1">CRUD Manzano, Villacrés, Reyes</td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td >Nombre<asp:TextBox ID="TextBox1" runat="server" Width="106px"></asp:TextBox>
&nbsp;Proveedor
                        <asp:TextBox ID="TextBox2" runat="server" Width="95px"></asp:TextBox>
&nbsp;Categoria
                        <asp:TextBox ID="TextBox3" runat="server" Width="116px"></asp:TextBox>
&nbsp;Cantidad
                        <asp:TextBox ID="TextBox4" runat="server" Width="139px"></asp:TextBox>
&nbsp;Precio
                        <asp:TextBox ID="TextBox5" runat="server" Width="121px"></asp:TextBox>
&nbsp;Existencia<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button_Agregar" runat="server" Text="Agregar" OnClick="Button_Agregar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">

                        <asp:Label ID="Label_Titulo" runat="server" Text="DATOS DEL PRODUCTO SELECCIONADO" Visible="False"></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:GridView ID="GridView2" runat="server" Width="100%" AutoGenerateColumns="False" 
                            CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ProductID" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" CssClass="auto-style2" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowCancelingEdit="GridView2_RowCancelingEdit" >
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                             <Columns>
                                 <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" />
                                 <asp:BoundField DataField="ProductName" HeaderText="Nombre" />
                                 <asp:BoundField DataField="SupplierID" HeaderText="Provedor" />
                                 <asp:BoundField DataField="CategoryID" HeaderText="Categoria" />
                                 <asp:BoundField DataField="QuantityPerUnit" HeaderText="Cantidad" />
                                 <asp:BoundField DataField="UnitPrice" HeaderText="Precio_Unitario" />
                                 <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" />
                                         
                                 <asp:CommandField ButtonType="Button" ShowSelectButton="True" >
                                         
                                 <ControlStyle BackColor="#3333FF" Font-Bold="True" ForeColor="#99CCFF" />
                                 </asp:CommandField>
                                         
                                 <asp:CommandField ShowEditButton="True" ButtonType="Button" >
                                         
                                 <ControlStyle BackColor="#009933" Font-Bold="True" ForeColor="#CCFFCC" />
                                 </asp:CommandField>
                                         
                                 <asp:CommandField ShowDeleteButton="True" ButtonType="Button" >
                                         
                                 <ControlStyle BackColor="#CC0000" BorderColor="Red" Font-Bold="True" ForeColor="White" />
                                 </asp:CommandField>
                                         
                </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>      
        </div>
    </form>
</body>
</html>
