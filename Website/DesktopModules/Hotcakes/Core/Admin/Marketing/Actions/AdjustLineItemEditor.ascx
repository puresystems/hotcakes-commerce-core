﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdjustLineItemEditor.ascx.cs" Inherits="Hotcakes.Modules.Core.Admin.Marketing.Actions.AdjustLineItemEditor" %>
<h1><%=Localization.GetString("DiscountQualifyingItemBy") %></h1>
<div class="hcColumnLeft hcForm" style="width: 50%">
    <div class="hcFormItemLabel">
        <label class="hcLabel"><%=Localization.GetString("AdjustPriceBy") %></label>
    </div>
    <div class="hcFormItem hcFormItem50p">
        <asp:TextBox ID="LineItemAdjustAmountField" runat="server" Columns="10"></asp:TextBox>
    </div>
    <div class="hcFormItem hcFormItem50p">
        <asp:DropDownList ID="lstLineItemAdjustType" runat="server" />
    </div>
</div>
