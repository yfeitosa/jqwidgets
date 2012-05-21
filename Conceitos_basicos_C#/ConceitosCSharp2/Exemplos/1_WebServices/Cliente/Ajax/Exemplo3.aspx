<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Exemplo3.aspx.cs" Inherits="Complexo_Exemplo3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../Scripts/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $("input[id$='Button1']").click(function () {
                jQuery.support.cors = true;
                var DropDownList1 = $("#DropDownList1");

                $.ajax({ type: "POST",
                    url: "http://localhost:2102/Servidor/Complexo/wsComplexo2.asmx/ListarRegistros",
                    data: "{}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {

                        var Registros = response.d;
                        alert("Retornou isso" + Registros);
                        DropDownList1.append('<option value="0">Selecione...</option>');

                        $.each(Registros, function (PosicaoRegistro, Registro) {
                            alert("Estou Carregando o Registro: " + PosicaoRegistro);
                            DropDownList1.append('<option value="' + Registro.ID_LINGUAGEM + '">' + Registro.NM_LINGUAGEM + '</option>');
                        });

                    },
                    error: function (Erro) {
                        alert(Erro.status + ' ' + Erro.statusText);
                    }
                });
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <input id="Button1" type="button" value="Carregar" /></div>
    </form>
</body>
</html>
