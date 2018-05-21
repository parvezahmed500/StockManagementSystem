$(document).ready(function() {
    $("#CategoryDropDown").change(function() {
        var selectedCategoryId = $("#CategoryDropDown").val();

        var data = { categoryId: selectedCategoryId }

        $.ajax({
            url: "/Products/GetProducts",
            data: data,
            type: "POST",
            success: function (response) {
                $("#ProductDropDown").empty();
                var options = "<option>Select --------</option>";
                $.each(response,function(key, product) {
                    options += "<option value='" + product.Id + "'>"+product.Name+"</option>";
                });
                $("#ProductDropDown").append(options);
            },
            error:function(response) {
                alert("There is no Data");
            }
    });
    });

    $("#btn_add").click(function() {
        var index = 0;
        var productId = $("#ProductDropDown").val();
        var productName = $("#ProductDropDown option:selected").text();
        var qty = $("#Quantity").val();

        var indexCell = "<td style='display:none'><input type='hidden' name='StockInDetails.Index' value='"+index+"'/></td>";
        var productNameCell = "<td><input type='hidden' name='StockInDetails["+index+"].ProductId' value='" + productId + "'/>" + productName + "</td>";
        var qtyCell = "<td><input type='hidden' name='StockInDetails[" + index + "].Quantity' value='" + qty + "'/>" + qty + "</td>";

        var tr = "<tr>" + indexCell + productNameCell + qtyCell + "<td><input type='checkbox' name='record'></td></tr>";

        //var tr = "<tr><td>" + productName + "</td><td>" + qty + "</td><td><input type='checkbox' name='record'> </td></tr>";

        $("tbody").append(tr);
        ++index;
    });

    $("#btn_delete").click(function() {
        $("table tbody").find('input[name="record"]').each(function() {
            if ($(this).is(":checked")) {
                $(this).parents("tr").remove();
            }
        });
    });

});



