    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Userlogin.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="imgs/All%20necessary%20Images/imgs/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                        Member Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr align="center" width="70%" size="3" color="#8080ff">
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Label">Member Id</asp:Label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="MEMBER ID"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Label">Password</asp:Label>
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder=" Password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Button  class="btn btn-success btn-block" ID="Button1" runat="server" 
                                        Text="Login" onclick="Button1_Click" />
                                </div>
                                <div class="form-group">
                                    <a href=usersignup.aspx> <input class="btn btn-primary btn-block" id="Button2" type="button" value="Sign UP" /></a>
                                </div>
              
                            </div>
                        </div>
                    </div>
                </div>
                <a href=Home.aspx><< Back to Home</a><br><br>
            </div>
        </div>
    </div>
</asp:Content>
