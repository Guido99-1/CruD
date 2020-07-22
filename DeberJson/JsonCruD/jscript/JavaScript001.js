function Producto(productID, productName, supplierID, categoryID, quantityPerUnit, unitPrice, unitsInStock) {
    this.ProductID=productID;
    this.ProductName = productName;
    this.SupplierID = supplierID;
    this.CategoryID = categoryID;
    this.QuantityPerUnit = quantityPerUnit;
    this.UnitPrice = unitPrice;
    this.UnitsInStock = unitsInStock;
}

function agregarProducto(p) {
    var p = new Producto();
    p.ProductName = document.getElementById("TextName").value;
    p.SupplierID = document.getElementById("TextSupplier").value;
    p.categoryID = document.getElementById("TextCategory").value;
    p.QuantityPerUnit = document.getElementById("TextQuantity").value;
    p.UnitPrice = document.getElementById("TextUnitPrice").value;
    p.UnitsInStock = document.getElementById("TextUnitsInStock").value;

}