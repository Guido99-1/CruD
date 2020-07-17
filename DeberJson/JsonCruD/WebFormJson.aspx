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
                        <asp:Button ID="Button_Agregar" runat="server" Text="Agregar" />
                    </td>
                </tr>
                
                <tr>
                    <td >
                        <asp:GridView ID="GridView2" runat="server" Width="100%" AutoGenerateColumns="False" 
                            CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ProductID" OnRowEditing="GridView2_RowEditing" OnRowDeleting="GridView2_RowDeleting" OnRowUpdating="GridView2_RowUpdating" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
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
                    <asp:TemplateField HeaderText="ProductID">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("ProductID") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxProductID" Text='<%# Eval("ProductID") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxProductIDFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                     
                     <asp:TemplateField HeaderText="ProductName">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("ProductName") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxProductName" Text='<%# Eval("ProductName") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxProductNameFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                     
                     <asp:TemplateField HeaderText="SupplierID">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("SupplierID") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxSupplierID" Text='<%# Eval("SupplierID") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxSupplierIDFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                      <asp:TemplateField HeaderText="CategoryID">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("CategoryID") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxCategoryID" Text='<%# Eval("CategoryID") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxCategoryIDFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="QuantityPerUnit">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("QuantityPerUnit") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxQuantityPerUnit" Text='<%# Eval("QuantityPerUnit") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxQuantityPerUnitFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="UnitPrice">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("UnitPrice") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxUnitPrice" Text='<%# Eval("UnitPrice") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxUnitPriceFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="UnitsInStock">
                       <ItemTemplate>
                            <asp:Label Text='<%# Eval("UnitsInStock") %>' runat="server"></asp:Label>
                       </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtBoxUnitsInStock" Text='<%# Eval("UnitsInStock") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                             <asp:TextBox ID="txtBoxUnitsInStockFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                                         
                                 <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                                         
                                 <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                                         
                </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>      
        </div>
    </form>
</body>
</html>
