<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarReservaTurnoDeRT.aspx.cs" Inherits="PPAI_2k1_2022.RegistrarReservaTurnoDeRT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Reserva de Turnos de un RT</h3>
    <hr />
    <asp:Button CssClass="btn btn-primary" runat="server" ID="btn_tomarOpcionRegistrarReservaRT" OnClick="btn_tomarOpcionRegistrarReservaRT_Click" Text="Registrar" />

    <asp:Panel runat="server" ID="pnlRegistrarReserva">
        <div class="container my-4">
            <div class="row my-4">
                <div class="form-group col-md-3">
                    <asp:Label runat="server">Seleccione tipo de RT :</asp:Label>
                    <asp:DropDownList CssClass="form-control" runat="server" ID="cbo_tipoRT">
                    </asp:DropDownList>
                </div>
                <div class="form-group col-md-2">
                    <asp:Button runat="server" Text="Seleccionar" CssClass="btn btn-primary mt-4" ID="btn_TomarTipoRT" OnClick="btn_TomarTipoRT_Click" />
                </div>
                <asp:Panel runat="server" ID="pnl_SinRT" CssClass="form-group col-md-4">
                    <p class="text-danger mt-4">No hay recursos tecnologicos para el tipo seleccionado</p>
                </asp:Panel>

                <div class="table-responsive my-4">
                    <asp:GridView runat="server" class="table table-responsive" AutoGenerateColumns="false" ID="GV_RecursosTecnologicos">

                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:Label runat="server" Text="Seleccionar" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox runat="server" CssClass="form-check" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Numero RT" DataField="NumeroRT" />
                            <asp:BoundField HeaderText="Fecha Alta" DataField="FechaAlta" />
                            <asp:BoundField HeaderText="Modelo" DataField="Modelo.Nombre" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>


            <div class="row">
                <div class="form-group col-md-2">
                    <asp:Label runat="server">Fecha del Turno :</asp:Label>
                    <asp:TextBox type="date" class="form-control" runat="server" ID="txtFecha" />
                </div>
                <div class="form-group col-md-2">
                    <asp:Label runat="server">Hora :</asp:Label>
                    <asp:TextBox type="time" class="form-control" runat="server" ID="txtHora" />
                </div>
                <div class="col-md-3 form-group">
                    <asp:Button runat="server" CssClass="btn btn-primary mt-4" Text="Reservar" ID="btn_Reservar" OnClick="btn_Reservar_Click" />
                </div>
            </div>

            <div class="row my-4">
                <div class="form-group col-md-2">
                    <asp:Label runat="server">Usuario :</asp:Label>
                    <asp:TextBox runat="server" CssClass="form-control" disabled="true" Text="Ignacio" />
                </div>
            </div>
            <hr />
        </div>
    </asp:Panel>

</asp:Content>
